using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Common.Physics;
using Entitas;

namespace Code.Gameplay.Features.TargetCollection.Systems
{
	public class CastForCollisionsWithNoLimitSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(128);

		private readonly IPhysicsService _physicsService;
		private readonly IGroup<GameEntity> _ready;

		public CastForCollisionsWithNoLimitSystem(GameContext game, IPhysicsService physicsService)
		{
			_physicsService = physicsService;
			_ready = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CollisionsBuffer,
					GameMatcher.Radius,
					GameMatcher.CollisionLayerMask,
					GameMatcher.WorldPosition,
					GameMatcher.ReadyToCollectTargets)
				.NoneOf(GameMatcher.TargetLimit));
		}

		public void Execute()
		{
			foreach (GameEntity ready in _ready.GetEntities(_buffer))
			{
				ready.CollisionsBuffer.AddRange(CollisionsInRadius(ready));

				if (ready.isCollectTargetsContinuously == false)
					ready.isReadyToCollectTargets = false;
			}
		}

		private IEnumerable<int> CollisionsInRadius(GameEntity entity) =>
			_physicsService
				.CircleCast(entity.WorldPosition, entity.Radius, entity.CollisionLayerMask)
				.Select(x => x.Id);
	}
}