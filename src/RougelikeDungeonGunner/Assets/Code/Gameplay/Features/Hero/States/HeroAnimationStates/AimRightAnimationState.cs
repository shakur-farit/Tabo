using Code.Gameplay.Features.Hero.Behaviours;

namespace Code.Gameplay.Features.Hero.States.HeroAnimationStates
{
	public class AimRightAnimationState : IHeroAnimationState
	{
		private HeroAnimator _heroAnimator;

		public void Enter(HeroAnimator heroAnimator)
		{
			_heroAnimator = heroAnimator;

			_heroAnimator.StartAimRight();
		}

		public void Exit() =>
			_heroAnimator.StopAimRight();
	}
}