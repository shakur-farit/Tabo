using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Common.Physics;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Collection.Systems
{
	public class CastForTargetsWithNoLimitSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(128);

		private readonly IPhysicsService _physicsService;
		private readonly IGroup<GameEntity> _ready;

		public CastForTargetsWithNoLimitSystem(GameContext game, IPhysicsService physicsService)
		{
			_physicsService = physicsService;
			_ready = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.TargetsBuffer,
					GameMatcher.Radius,
					GameMatcher.TargetLayerMask,
					GameMatcher.WorldPosition,
					GameMatcher.ReadyToCollectTargets)
				.NoneOf(GameMatcher.TargetLimit));
		}

		public void Execute()
		{
			foreach (GameEntity ready in _ready.GetEntities(_buffer))
			{
				ready.TargetsBuffer.AddRange(TargetsInRadius(ready));

				if (ready.isCollectTargetsContinuously == false)
					ready.isReadyToCollectTargets = false;
			}
		}

		private IEnumerable<int> TargetsInRadius(GameEntity entity)
		{
			Vector2 center = entity.WorldPosition;

			if (entity.hasCastStartPositionTransform)
				 center = entity.CastStartPositionTransform.position;

			return _physicsService
				.CircleCast(center, entity.Radius, entity.TargetLayerMask)
				.Select(x => x.Id);
		}
	}
}