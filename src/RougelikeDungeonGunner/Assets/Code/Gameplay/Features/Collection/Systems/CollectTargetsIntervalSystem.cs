using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Collection.Systems
{
	public class CollectTargetsIntervalSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(128);

		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _entities;

		public CollectTargetsIntervalSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CollectTargetsInterval,
					GameMatcher.CollectTargetsTimer));
		}

		public void Execute()
		{
			foreach (GameEntity entity in _entities.GetEntities(_buffer))
			{
				entity.ReplaceCollectTargetsTimer(entity.CollectTargetsTimer - _time.DeltaTime);

				if (entity.CollectTargetsTimer <= 0)
				{
					entity.isReadyToCollectTargets = true;
					entity.ReplaceCollectTargetsTimer(entity.CollectTargetsInterval);
				}
			}
		}
	}
}