using Code.Gameplay.Features.Enemy.Behaviours;

namespace Code.Gameplay.Features.Hero.States
{
	public interface IEnemyAnimationState
	{
		void Enter(EnemyAnimator enemyAnimator);
		void Exit();
	}
}