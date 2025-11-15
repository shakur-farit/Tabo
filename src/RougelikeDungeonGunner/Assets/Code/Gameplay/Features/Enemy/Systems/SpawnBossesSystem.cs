using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Enemy.Services;
using Code.Gameplay.Features.Level.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class SpawnBossesSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IEnemyFactory _enemyFactory;
		private readonly IEnemySpawnPositionProvider _positionProvider;
		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _dungeons;

		public SpawnBossesSystem(
			GameContext game,
			IEnemyFactory enemyFactory,
			IEnemySpawnPositionProvider positionProvider)
		{
			_enemyFactory = enemyFactory;
			_positionProvider = positionProvider;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.BossWave,
					GameMatcher.EnemiesDefeated));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));

			_dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Dungeon,
					GameMatcher.EnemySpawnValidPositions));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			foreach (GameEntity dungeon in _dungeons)
			foreach (GameEntity hero in _heroes)
			{
				foreach (BossesInWave boss in level.BossWave.Bosses)
					for (int i = 0; i < boss.Amount; i++)
						_enemyFactory.CreateEnemy(boss.EnemyTypeId, GetPosition(
							hero.WorldPosition,
							level.HeroSafeZoneRadius,
							dungeon.EnemySpawnValidPositions))
							.With(x => x.isBoss = true);
			}
		}

		private Vector2 GetPosition(Vector2 heroPosition, float safeZoneRadius, List<Vector2Int> validPositions) =>
			_positionProvider.GetEnemyPosition(heroPosition, safeZoneRadius, validPositions);
	}
}