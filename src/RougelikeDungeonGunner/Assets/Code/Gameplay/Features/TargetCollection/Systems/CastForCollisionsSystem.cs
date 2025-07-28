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
			Vector2 start = new(entity.WorldPosition.x,entity.WorldPosition.y + entity.CastOriginOffset);
			Vector2 end = start + entity.Direction.normalized * entity.ForwardCastDistance;

			Debug.DrawLine(start, end, Color.cyan, 0f, false);

			GameEntity collision = _physicsService.LineCast(start, end, CollisionLayer.Collision.AsMask());

			return collision != null;
		}
	}
}