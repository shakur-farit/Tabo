using Code.Gameplay.Features.Hero.Behaviours;

namespace Code.Gameplay.Features.Hero.States
{
	public class AimLeftAnimationState : IHeroAnimationState
	{
		private HeroAnimator _heroAnimator;

		public void Enter(HeroAnimator heroAnimator)
		{
			_heroAnimator = heroAnimator;

			_heroAnimator.StartAimLeft();
		}

		public void Exit() =>
			_heroAnimator.StopAimLeft();
	}
}