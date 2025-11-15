using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Level.Systems
{
	public class MarkLevelBossesDefeatedSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);
		private readonly IGroup<GameEntity> _levels;

		public MarkLevelBossesDefeatedSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level,
					GameMatcher.BossCount));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				if (level.BossCount <= 0)
					level.isBossesDefeated = true;
			}
		}
	}
}