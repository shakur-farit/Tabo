using Code.Infrastructure.View.Registrars;

namespace Code.Gameplay.Features.Hero.Behaviours
{
	public class HeroAnimatorRegistrar : EntityComponentRegistrar
	{
		public HeroAnimator HeroAnimator;

		public override void RegisterComponents()
		{
			Entity
				.AddHeroAnimator(HeroAnimator);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasHeroAnimator)
				Entity.RemoveHeroAnimator();
		}
	}
}