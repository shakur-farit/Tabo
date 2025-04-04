using System.Collections.Generic;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Levels
{
	public class EnemyWaveOnLevelSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;
		private readonly List<GameEntity> _buffer = new(1);

		public EnemyWaveOnLevelSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWaves,
					GameMatcher.CooldownUp));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				if (level.SpawnedEnemyWaves < level.EnemyWaves.Count)
				{
					EnemyWave enemyWave = level.EnemyWaves[level.SpawnedEnemyWaves];

					level
						.ReplaceEnemyWave(enemyWave)
						.ReplaceSpawnedEnemyWaves(level.SpawnedEnemyWaves + 1)
						.PutOnCooldown()
						;
				}
			}
		}
	}
}