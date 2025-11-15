using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Level.Systems
{
	public class MarkLevelEnemiesDefeatedSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);
		private readonly IGroup<GameEntity> _levels;

		public MarkLevelEnemiesDefeatedSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level, 
					GameMatcher.EnemiesInLevelCount));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				if(level.EnemiesInLevelCount <= 0)
					level.isEnemiesDefeated = true;
			}
		}
	}
}