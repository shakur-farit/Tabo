using Code.Gameplay.Features.Hero.Behaviours;

namespace Code.Gameplay.Features.Hero.States
{
	public interface IHeroAnimationState
	{
		void Enter(HeroAnimator heroAnimator);
		void Exit();
	}
}