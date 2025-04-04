using Code.Gameplay.Features.Enemy.Behaviours;
using Code.Gameplay.Features.Hero.States;
using Code.Infrastructure.States.Factory;

namespace Code.Gameplay.Features.Enemy.States.StateMachine
{
	public class EnemyAnimationStateMachine : IEnemyAnimationStateMachine
	{
		private IEnemyAnimationState _activeState;
		private readonly IStateFactory _stateFactory;

		public EnemyAnimationStateMachine(IStateFactory stateFactory) =>
			_stateFactory = stateFactory;

		public void Enter<TState>(EnemyAnimator enemyAnimator) where TState : class, IEnemyAnimationState
		{
			IEnemyAnimationState state = ChangeState<TState>();
			state.Enter(enemyAnimator);
		}

		private TState ChangeState<TState>() where TState : class, IEnemyAnimationState
		{
			_activeState?.Exit();

			TState state = _stateFactory.GetEnemyAnimationState<TState>();
			_activeState = state;

			return state;
		}
	}
}