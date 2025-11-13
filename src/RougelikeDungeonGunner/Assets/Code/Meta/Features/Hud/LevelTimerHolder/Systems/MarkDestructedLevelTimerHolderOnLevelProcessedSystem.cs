using System.Collections.Generic;
using Entitas;

namespace Code.Meta.Features.Hud
{
	public class MarkDestructedLevelTimerHolderOnLevelProcessedSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _holders;

		public MarkDestructedLevelTimerHolderOnLevelProcessedSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level,
					GameMatcher.Processed));

			_holders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.TimerHolder));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			foreach (GameEntity holder in _holders.GetEntities(_buffer))
				holder.isDestructed = true;
		}
	}
}