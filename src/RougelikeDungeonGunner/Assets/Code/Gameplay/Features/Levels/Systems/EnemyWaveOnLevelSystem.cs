using System.Collections.Generic;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;

namespace Code.Gameplay.Features.Levels
{
	public class EnemyWaveOnLevelSystem : IExecuteSystem
	{
		private readonly IEnemyWaveFactory _enemyWaveFactory;
		private readonly IGroup<GameEntity> _levels;
		private readonly List<GameEntity> _buffer = new(1);

		public EnemyWaveOnLevelSystem(GameContext game, IEnemyWaveFactory enemyWaveFactory)
		{
			_enemyWaveFactory = enemyWaveFactory;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWaves,
					GameMatcher.CooldownUp));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				if (level.CreatedEnemyWaves < level.EnemyWaves.Count)
				{
					EnemyWave enemyWave = level.EnemyWaves[level.CreatedEnemyWaves];

					_enemyWaveFactory.CreateEnemyWave(enemyWave);

					level
						.ReplaceCreatedEnemyWaves(level.CreatedEnemyWaves + 1)
						.PutOnCooldown()
						;
				}
			}
		}
	}
}