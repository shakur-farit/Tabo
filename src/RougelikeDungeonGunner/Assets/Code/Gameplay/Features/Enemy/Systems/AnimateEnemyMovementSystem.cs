using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class AnimateEnemyMovementSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enemies;

		public AnimateEnemyMovementSystem(GameContext game)
		{
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.EnemyAnimator,
					GameMatcher.Moving));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			{
				if (enemy.isMoving)
				{
					enemy.EnemyAnimator.StartMoving();
					enemy.EnemyAnimator.StartAimDown();
				}
				else
				{
					enemy.EnemyAnimator.StartIdling();
				}
			}
		}
	}
}