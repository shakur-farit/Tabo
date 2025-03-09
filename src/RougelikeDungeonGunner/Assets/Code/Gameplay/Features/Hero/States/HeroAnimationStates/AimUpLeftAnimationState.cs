using Code.Gameplay.Features.Hero.Behaviours;

namespace Code.Gameplay.Features.Hero.States
{
	public class AimUpLeftAnimationState : IHeroAnimationState
	{
		private HeroAnimator _heroAnimator;

		public void Enter(HeroAnimator heroAnimator)
		{
			_heroAnimator = heroAnimator;

			_heroAnimator.StartAimUpLeft();
		}

		public void Exit() =>
			_heroAnimator.StopAimUpLeft();
	}
}