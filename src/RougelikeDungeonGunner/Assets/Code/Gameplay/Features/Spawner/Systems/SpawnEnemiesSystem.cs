using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Levels;
using Code.Gameplay.Features.Levels.Configs;
using Code.Gameplay.StaticData;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Spawner.Systems
{
	public class SpawnEnemiesSystem : IExecuteSystem
	{
		private readonly IEnemyFactory _enemyFactory;
		private readonly IRandomService _randomService;
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _spawners;

		public SpawnEnemiesSystem(
			GameContext game, 
			IEnemyFactory enemyFactory,
			IRandomService randomService,
			IStaticDataService staticDataService)
		{
			_enemyFactory = enemyFactory;
			_randomService = randomService;
			_staticDataService = staticDataService;
			_spawners = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CurrentSpawnedEnemyAmount
					));
		}

		public void Execute()
		{
			foreach (GameEntity spawner in _spawners)
			{
				int enemyAmountInWave = 0;

				foreach (EnemyWave enemyWave in _staticDataService.GetLevelConfig(LevelTypeId.First).EnemyWaves)
				{
					enemyAmountInWave += enemyWave.Amount;
				}

				if (spawner.CurrentSpawnedEnemyAmount < enemyAmountInWave)
				{
					_enemyFactory.CreateEnemy(EnemyTypeId.Orc, RandomPosition());

					spawner.ReplaceCurrentSpawnedEnemyAmount(spawner.CurrentSpawnedEnemyAmount + 1);
				}
			}
		}

		private Vector2 RandomPosition() =>
			new(_randomService.Range(-10f, 10f),
				_randomService.Range(-10f, 10f));
	}
}