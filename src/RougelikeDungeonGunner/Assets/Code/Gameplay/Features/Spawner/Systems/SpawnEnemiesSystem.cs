using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Enemy.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Spawner.Systems
{
	public class SpawnEnemiesSystem : IExecuteSystem
	{
		private readonly IEnemyFactory _enemyFactory;
		private readonly IRandomService _randomService;
		private readonly IGroup<GameEntity> _spawners;

		public SpawnEnemiesSystem(
			GameContext game, 
			IEnemyFactory enemyFactory,
			IRandomService randomService)
		{
			_enemyFactory = enemyFactory;
			_randomService = randomService;
			_spawners = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CurrentSpawnedEnemyAmount));
		}

		public void Execute()
		{
			foreach (GameEntity spawner in _spawners)
			{
				if (spawner.CurrentSpawnedEnemyAmount < 3)
				{
					_enemyFactory.CreateEnemy(RandomPosition(), EnemyTypeId.Orc);

					spawner.ReplaceCurrentSpawnedEnemyAmount(spawner.CurrentSpawnedEnemyAmount + 1);
				}
			}
		}

		private Vector2 RandomPosition() =>
			new(_randomService.Range(-10f, 10f),
				_randomService.Range(-10f, 10f));
	}
}