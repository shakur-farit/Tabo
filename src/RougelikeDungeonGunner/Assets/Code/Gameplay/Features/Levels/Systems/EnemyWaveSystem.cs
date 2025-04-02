using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Levels
{
	public class EnemyWaveSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;

		public EnemyWaveSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWaves));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			foreach (EnemyWave enemyWave in level.EnemyWaves)
			{
				CreateEntity.Empty()
					.AddEnemyWave(enemyWave)
					;

				Debug.Log("Create Wave");

				}
		}
	}
}