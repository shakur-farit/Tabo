using System.Collections.Generic;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Levels.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class SpawnEnemiesSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IEnemyFactory _enemyFactory;
		private readonly IEnemySpawnPositionProvider _positionProvider;
		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _dungeons;

		public SpawnEnemiesSystem(
			GameContext game,
			IEnemyFactory enemyFactory,
			IEnemySpawnPositionProvider positionProvider)
		{
			_enemyFactory = enemyFactory;
			_positionProvider = positionProvider;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWave));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));

			_dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Dungeon,
					GameMatcher.ValidPositions));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			foreach (GameEntity dungeon in _dungeons)
			foreach (GameEntity hero in _heroes)
			{
				foreach (EnemiesInWave enemiesInWave in level.EnemyWave.EnemiesInWave)
					for (int i = 0; i < enemiesInWave.Amount; i++)
						_enemyFactory.CreateEnemy(enemiesInWave.EnemyTypeId, GetPosition(
							hero.WorldPosition, 
							level.HeroSafeZoneRadius,
							dungeon.ValidPositions));

				level.RemoveEnemyWave();
			}
		}

		private Vector2 GetPosition(Vector2 heroPosition, float safeZoneRadius, List<Vector2> validPositions) =>
			_positionProvider.GetEnemyPosition(heroPosition, safeZoneRadius, validPositions);
	}
}