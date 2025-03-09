using Code.Gameplay.Features.Hero.Behaviours;

namespace Code.Gameplay.Features.Hero.States
{
	public class AimUpRightAnimationState : IHeroAnimationState
	{
		private HeroAnimator _heroAnimator;

		public void Enter(HeroAnimator heroAnimator)
		{
			_heroAnimator = heroAnimator;

			_heroAnimator.StartAimUpRight();
		}

		public void Exit() =>
			_heroAnimator.StopAimUpRight();
	}
}