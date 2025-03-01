using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Enemy.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class EnemySpawnSystem : IInitializeSystem
	{
		private readonly IEnemyFactory _enemyFactory;
		private readonly IRandomService _randomService;

		public EnemySpawnSystem(IEnemyFactory enemyFactory, IRandomService randomService)
		{
			_enemyFactory = enemyFactory;
			_randomService = randomService;
		}

		public void Initialize()
		{
			for (int i = 0; i < 3; i++)
			{
				_enemyFactory.CreateEnemy(RandomPosition(), EnemyTypeId.Orc);
			}
		}

		private Vector2 RandomPosition() => 
			new(_randomService.Range(-10f, 10f), 
				_randomService.Range(-10f, 10f));
	}
}