using System.Collections.Generic;
using Entitas;

namespace Code.Meta.Features.Hud
{
	public class MarkDestructedCoinsHolderOnLevelProcessedSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _holders;

		public MarkDestructedCoinsHolderOnLevelProcessedSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level,
					GameMatcher.Processed));

			_holders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CoinsHolder));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			foreach (GameEntity holder in _holders.GetEntities(_buffer))
				holder.isDestructed = true;
		}
	}
}