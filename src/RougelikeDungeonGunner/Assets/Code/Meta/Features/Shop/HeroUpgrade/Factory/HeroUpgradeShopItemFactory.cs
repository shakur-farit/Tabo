using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.HeroUpgrade.Behaviours;
using Code.Meta.Features.Shop.HeroUpgrade.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.HeroUpgrade.Factory
{
	public class HeroUpgradeShopItemFactory : IHeroUpgradeShopItemFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public HeroUpgradeShopItemFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public HeroUpgradeShopItem CreateHeroUpgradeShopItem(HeroUpgradeTypeId id, Transform parent)
		{
			HeroUpgradeShopItemConfig config = _staticDataService.GetHeroUpgradeShopItemConfig(id);

			HeroUpgradeShopItem item = _instantiator.InstantiatePrefabForComponent<HeroUpgradeShopItem>(config.ViewPrefab, parent);

			item.Setup(config);

			return item;
		}
	}
}