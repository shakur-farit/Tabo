using Code.Gameplay.Features.Enemy.Behaviours;

namespace Code.Gameplay.Features.Hero.States.HeroAnimationStates
{
	public class EnemyDownDirectionAnimationState : IEnemyAnimationState
	{
		private EnemyAnimator _enemyAnimator;

		public void Enter(EnemyAnimator enemyAnimator)
		{
			_enemyAnimator = enemyAnimator;

			_enemyAnimator.StartLookDownAnimation();
		}

		public void Exit() =>
			_enemyAnimator.StopLookDownAnimation();
	}
}