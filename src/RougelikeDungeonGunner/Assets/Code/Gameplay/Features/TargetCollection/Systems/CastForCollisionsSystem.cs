using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Common.Physics;
using Entitas;
using Unity.Burst.CompilerServices;
using UnityEngine;

namespace Code.Gameplay.Features.TargetCollection.Systems
{
	public class CastForCollisionsSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(128);

		private readonly IPhysicsService _physicsService;
		private readonly IGroup<GameEntity> _entities;

		public CastForCollisionsSystem(GameContext game, IPhysicsService physicsService)
		{
			_physicsService = physicsService;
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.ForwardCastDistance,
					GameMatcher.CastOriginOffset,
					GameMatcher.BoxCastWidth,
					GameMatcher.BoxCastHeight,
					GameMatcher.WorldPosition,
					GameMatcher.Direction));
		}

		public void Execute()
		{
			foreach (GameEntity entity in _entities.GetEntities(_buffer))
				entity.isCollisionInFront = HasCollisionsInFront(entity);
		}

		private bool HasCollisionsInFront(GameEntity entity)
		{
			Vector2 dir = entity.Direction.normalized;

			Vector2 center = (Vector2)entity.WorldPosition + dir * entity.ForwardCastDistance * 0.5f + Vector2.up * entity.CastOriginOffset;
			Vector2 halfSize = new(entity.BoxCastWidth * 0.5f, entity.BoxCastHeight * 0.5f);

			Vector2 lineStart;
			Vector2 lineEnd;

			if (Mathf.Abs(dir.x) > Mathf.Abs(dir.y))
			{
				float x = dir.x > 0 ? center.x + halfSize.x : center.x - halfSize.x;
				lineStart = new Vector2(x, center.y - halfSize.y);
				lineEnd = new Vector2(x, center.y + halfSize.y);
			}
			else
			{
				float y = dir.y > 0 ? center.y + halfSize.y : center.y - halfSize.y;
				lineStart = new Vector2(center.x - halfSize.x, y);
				lineEnd = new Vector2(center.x + halfSize.x, y);
			}

			Debug.DrawLine(lineStart, lineEnd, Color.magenta, 0f, false);

			GameEntity collision = _physicsService.LineCast(lineStart, lineEnd, CollisionLayer.Collision.AsMask());

			return collision != null;
		}
	}
}