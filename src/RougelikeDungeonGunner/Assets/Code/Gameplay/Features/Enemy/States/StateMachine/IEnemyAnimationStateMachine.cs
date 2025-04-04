using Code.Gameplay.Features.Enemy.Behaviours;
using Code.Gameplay.Features.Hero.States;

namespace Code.Gameplay.Features.Enemy.States.StateMachine
{
	public interface IEnemyAnimationStateMachine
	{
		void Enter<TState>(EnemyAnimator enemyAnimator) where TState : class, IEnemyAnimationState;
	}
}