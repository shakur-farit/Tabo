using System.Collections.Generic;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class SpawnEnemiesSystem : IExecuteSystem
	{
		private readonly IEnemyFactory _enemyFactory;
		private readonly IRandomService _randomService;
		private readonly IGroup<GameEntity> _levels;
		private readonly List<GameEntity> _buffer = new(1);

		public SpawnEnemiesSystem(
			GameContext game,
			IEnemyFactory enemyFactory,
			IRandomService randomService)
		{
			_enemyFactory = enemyFactory;
			_randomService = randomService;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWave));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				foreach (EnemiesInWave enemiesInWave in level.EnemyWave.EnemiesInWave)
					for (int i = 0; i < enemiesInWave.Amount; i++)
						_enemyFactory.CreateEnemy(enemiesInWave.EnemyTypeId, RandomPosition());

				level.RemoveEnemyWave();
			}
		}

		private Vector2 RandomPosition() =>
			new(_randomService.Range(-10f, 10f),
				_randomService.Range(-10f, 10f));
	}
}