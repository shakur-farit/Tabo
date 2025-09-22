using Assets.Code.Gameplay.Features.Hero.Behaviours;
using Assets.Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Registrars
{
	public class HeroAnimatorRegistrar : EntityComponentRegistrar
	{
		[SerializeField] public HeroAnimator _heroAnimator;

		public override void RegisterComponents()
		{
			Entity
				.AddHeroAnimator(_heroAnimator)
				.AddDamageTakenAnimator(_heroAnimator);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasHeroAnimator)
				Entity.RemoveHeroAnimator();

			if (Entity.hasDamageTakenAnimator)
				Entity.RemoveDamageTakenAnimator();
		}
	}
}