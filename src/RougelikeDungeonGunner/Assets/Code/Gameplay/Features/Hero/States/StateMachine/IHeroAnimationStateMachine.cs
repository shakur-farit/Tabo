using Code.Gameplay.Features.Hero.Behaviours;

namespace Code.Gameplay.Features.Hero.States.StateMachine
{
	public interface IHeroAnimationStateMachine
	{
		void Enter<TState>(HeroAnimator heroAnimator) where TState : class, IHeroAnimationState;
	}
}