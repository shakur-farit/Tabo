using Code.Gameplay.StaticData;
using Code.Infrastructure.AssetManagement;
using Code.Meta.Features.Hud.Config;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Hud.AmmoHolder.Factory
{
	public class AmmoUIFactory : IAmmoUIFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public AmmoUIFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public GameObject CreateAmmoUI(Transform parent)
		{
			HudConfig config = _staticDataService.GetHudConfig();

			return _instantiator.InstantiatePrefab(config.AmmoUIViewPrefab, parent);
		}
	}
}