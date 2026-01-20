using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Enemy.Services;
using Code.Gameplay.Features.Level.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class CreateEnemiesSpawnRequestSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IEnemySpawnPositionProvider _positionProvider;
    private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _dungeons;

		public CreateEnemiesSpawnRequestSystem(GameContext game, IEnemySpawnPositionProvider positionProvider)
		{
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
					GameMatcher.EnemySpawnValidPositions));
		}

		public void Execute()
    {
      foreach (GameEntity level in _levels.GetEntities(_buffer))
			foreach (GameEntity dungeon in _dungeons)
			foreach (GameEntity hero in _heroes)
			{
				foreach (EnemiesInWave enemiesInWave in level.EnemyWave.EnemiesInWave)
          for (int i = 0; i < enemiesInWave.Amount; i++)
            CreateGameEntity.Empty()
              .AddEnemyTypeId(enemiesInWave.EnemyTypeId)
              .AddSpawnPosition(GetPosition(hero.WorldPosition, level.HeroSafeZoneRadius,
                dungeon.EnemySpawnValidPositions))
              .With(x => x.isSpawnRequest = true);

        level.RemoveEnemyWave();
			}
		}

		private Vector2 GetPosition(Vector2 heroPosition, float safeZoneRadius, List<Vector2Int> validPositions) =>
			_positionProvider.GetEnemyPosition(heroPosition, safeZoneRadius, validPositions);
	}
}