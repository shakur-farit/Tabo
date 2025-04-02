using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Spawner.Systems
{
	public class SpawnEnemiesSystem : IExecuteSystem
	{
		private readonly IEnemyFactory _enemyFactory;
		private readonly IRandomService _randomService;
		private readonly IGroup<GameEntity> _spawners;
		private readonly IGroup<GameEntity> _waves;

		public SpawnEnemiesSystem(
			GameContext game,
			IEnemyFactory enemyFactory,
			IRandomService randomService)
		{
			_enemyFactory = enemyFactory;
			_randomService = randomService;
			_spawners = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CurrentSpawnedEnemyAmount
				));

			_waves = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWave
				));
		}

		public void Execute()
		{
			foreach (GameEntity spawner in _spawners)
			foreach (GameEntity wave in _waves)
			foreach (EnemiesInWave enemiesInWave in wave.EnemyWave.EnemiesInWave)
			{
				//_enemyFactory.CreateEnemy(enemiesInWave.EnemyTypeId, RandomPosition());

				//spawner.ReplaceCurrentSpawnedEnemyAmount(spawner.CurrentSpawnedEnemyAmount + 1);

				Debug.Log("Create Enemy");
			}
		}

		private Vector2 RandomPosition() =>
			new(_randomService.Range(-10f, 10f),
				_randomService.Range(-10f, 10f));
	}
}