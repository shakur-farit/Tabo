using System.Collections.Generic;
using Code.Gameplay.Features.TargetCollection;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class EnemyDeathSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(128);

		private readonly IGroup<GameEntity> _enemies;

		public EnemyDeathSystem(GameContext game)
		{
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.Dead,
					GameMatcher.ProcessingDeath,
					GameMatcher.EnemyAnimator));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies.GetEntities(_buffer))
			{
				enemy.isMovementAvailable = false;
				enemy.RemoveTargetCollectionComponents();
				enemy.EnemyAnimator.PlayDied();
				enemy.ReplaceSelfDestructedTimer(2);
			}
		}
	}
}