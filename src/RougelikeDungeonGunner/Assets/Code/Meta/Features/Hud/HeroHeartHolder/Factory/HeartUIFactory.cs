using Code.Gameplay.StaticData;
using Code.Meta.Features.Hud.Config;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Hud.HeroHeartHolder.Factory
{
	public class HeartUIFactory : IHeartUIFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public HeartUIFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public GameObject CreateHeartUI(Transform parent)
		{
			HudConfig config = _staticDataService.GetHudConfig();

			return _instantiator.InstantiatePrefab(config.HeathViewPrefab, parent);
		}
	}
}