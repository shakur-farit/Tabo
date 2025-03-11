using Code.Gameplay.Features.Hero.Behaviours;

namespace Code.Gameplay.Features.Hero.States.HeroAnimationStates
{
	public class AimDownAnimationState : IHeroAnimationState
	{
		private HeroAnimator _heroAnimator;

		public void Enter(HeroAnimator heroAnimator)
		{
			_heroAnimator = heroAnimator;

			_heroAnimator.StartAimDown();
		}

		public void Exit() =>
			_heroAnimator.StopAimDown();
	}
}