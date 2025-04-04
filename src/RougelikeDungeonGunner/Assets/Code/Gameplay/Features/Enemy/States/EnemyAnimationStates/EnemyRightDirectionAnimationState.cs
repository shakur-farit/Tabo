using Code.Gameplay.Features.Enemy.Behaviours;
using Code.Gameplay.Features.Hero.Behaviours;

namespace Code.Gameplay.Features.Hero.States.HeroAnimationStates
{
	public class EnemyRightDirectionAnimationState : IEnemyAnimationState
	{
		private EnemyAnimator _enemyAnimator;

		public void Enter(EnemyAnimator enemyAnimator)
		{
			_enemyAnimator = enemyAnimator;

			_enemyAnimator.StartLookRightAnimation();
		}

		public void Exit() =>
			_enemyAnimator.StopLookRightAnimation();
	}
}