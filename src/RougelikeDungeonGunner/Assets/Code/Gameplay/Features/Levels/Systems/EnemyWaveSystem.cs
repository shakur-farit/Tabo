using System.Collections.Generic;
using Code.Common.Entity;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Levels
{
	public class EnemyWaveSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;
		private readonly List<GameEntity> _buffer = new(1);

		public EnemyWaveSystem(GameContext game)
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
				if (level.CreatedEnemyWavesAmount < level.EnemyWaves.Count)
				{
					EnemyWave enemyWave = level.EnemyWaves[level.CreatedEnemyWavesAmount];

					CreateEntity.Empty()
						.AddEnemyWave(enemyWave)
						;

					level
						.ReplaceCreatedEnemyWavesAmount(level.CreatedEnemyWavesAmount + 1)
						.PutOnCooldown()
						;

					Debug.Log("Create Wave");
				}
			}
		}
	}
}