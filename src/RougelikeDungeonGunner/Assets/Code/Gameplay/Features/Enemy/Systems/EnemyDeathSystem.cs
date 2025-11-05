using System.Collections.Generic;
using Code.Gameplay.Features.Collection;
using Code.Gameplay.Features.Hero.Services;
using Code.Meta;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class EnemyDeathSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(128);

		private readonly IScoreService _scoreService;

		private readonly IGroup<GameEntity> _enemies;
		private readonly IGroup<GameEntity> _levels;

		public EnemyDeathSystem(GameContext game, IScoreService scoreService)
		{
			_scoreService = scoreService;
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.Dead,
					GameMatcher.ProcessingDeath,
					GameMatcher.ScoreValue,
					GameMatcher.EnemyAnimator));

			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemiesInLevelCount));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			foreach (GameEntity enemy in _enemies.GetEntities(_buffer))
			{
				enemy.isMovementAvailable = false;
				enemy.RemoveTargetCollectionComponents();
				enemy.EnemyAnimator.PlayDied();
        enemy.isDestructed = true;

				_scoreService.IncreaseScore(enemy.ScoreValue);

				level.ReplaceEnemiesInLevelCount(level.EnemiesInLevelCount - 1);
			}
		}
	}
}