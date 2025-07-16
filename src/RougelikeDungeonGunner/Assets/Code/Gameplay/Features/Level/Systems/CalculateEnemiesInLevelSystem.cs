using System.Collections.Generic;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;

namespace Code.Gameplay.Features.Levels.Systems
{
	public class CalculateEnemiesInLevelSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;
		private readonly List<GameEntity> _buffer = new(1);

		public CalculateEnemiesInLevelSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemiesInLevelCount,
					GameMatcher.EnemyWaves)
				.NoneOf(GameMatcher.EnemiesInLevelCountCalculated));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				foreach (EnemyWave enemyWave in level.EnemyWaves)
				foreach (EnemiesInWave enemiesInWave in enemyWave.EnemiesInWave)
					level.ReplaceEnemiesInLevelCount(level.EnemiesInLevelCount + enemiesInWave.Amount);

				level.isEnemiesInLevelCountCalculated = true;
			}
		}
	}
}