using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Common.Physics;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Collection.Systems
{
	public class CastLineForCollisionsSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(128);

		private readonly IPhysicsService _physicsService;
		private readonly IGroup<GameEntity> _entities;

		public CastLineForCollisionsSystem(GameContext game, IPhysicsService physicsService)
		{
			_physicsService = physicsService;
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.ForwardCastDistance,
					GameMatcher.CastStartPositionTransform,
					GameMatcher.WorldPosition,
					GameMatcher.Direction)
				.NoneOf(GameMatcher.BoxCastHeight, GameMatcher.BoxCastWidth));
		}

		public void Execute()
		{
			foreach (GameEntity entity in _entities.GetEntities(_buffer))
				entity.isCollisionInFront = HasCollisionsInFront(entity);
		}

		private bool HasCollisionsInFront(GameEntity entity)
		{
			Vector2 dir = entity.Direction.normalized;
			Vector2 start = entity.CastStartPositionTransform.position;
			Vector2 end = start + dir * entity.ForwardCastDistance;

			Debug.DrawLine(start, end, Color.cyan, 0f, false);

			GameEntity collision = _physicsService.LineCast(start, end, CollisionLayer.Collision.AsMask());

			Vector2 normal = Vector2.zero;

			if (collision != null)
			{
				normal = Mathf.Abs(dir.x) > Mathf.Abs(dir.y) ? 
					new Vector2(dir.x > 0 ? -1f : 1f, 0f) : 
					new Vector2(0f, dir.y > 0 ? -1f : 1f);
			}

			entity.ReplaceCollisionNormal(normal);
			return collision != null;
		}
	}
}