using Code.Gameplay.Features.Hero.Behaviours;
using Code.Infrastructure.States.Factory;

namespace Code.Gameplay.Features.Hero.States.StateMachine
{
	public class HeroAnimationStateMachine : IHeroAnimationStateMachine
	{
		private IHeroAnimationState _activeState;
		private readonly IStateFactory _stateFactory;

		public HeroAnimationStateMachine(IStateFactory stateFactory) =>
			_stateFactory = stateFactory;

		public void Enter<TState>(HeroAnimator heroAnimator) where TState : class, IHeroAnimationState
		{
			IHeroAnimationState state = ChangeState<TState>();
			state.Enter(heroAnimator);
		}

		private TState ChangeState<TState>() where TState : class, IHeroAnimationState
		{
			_activeState?.Exit();

			TState state = _stateFactory.GetHeroAnimationState<TState>();
			_activeState = state;

			return state;
		}
	}
}