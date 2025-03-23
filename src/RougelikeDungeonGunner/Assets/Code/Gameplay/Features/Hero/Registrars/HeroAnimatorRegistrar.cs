using Code.Gameplay.Features.Hero.Behaviours;
using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Hero.Registrars
{
	public class HeroAnimatorRegistrar : EntityComponentRegistrar
	{
		[SerializeField] public HeroAnimator _heroAnimator;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) => 
			_staticDataService = staticDataService;

		public override void RegisterComponents()
		{
			Entity
				.AddHeroAnimator(_heroAnimator)
				.AddDamageTakenAnimator(_heroAnimator);

			HeroTypeId typeId = Entity.HeroTypeId;
			HeroConfig config = _staticDataService.GetHeroConfig(typeId);

			_heroAnimator.SetRuntimeAnimatorController(config.AnimatorController);

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