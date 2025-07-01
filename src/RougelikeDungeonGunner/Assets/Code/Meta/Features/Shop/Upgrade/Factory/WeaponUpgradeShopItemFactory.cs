using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Beahaviours;
using Code.Meta.Features.Shop.Upgrade.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.Upgrade.Factory
{
	public class WeaponUpgradeShopItemFactory : IWeaponUpgradeShopItemFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public WeaponUpgradeShopItemFactory(IInstantiator instantiator , IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public WeaponUpgradeShopItem CreateUpgradeWeaponShopItem(WeaponUpgradeTypeId typeId, Transform parent)
		{
			WeaponUpgradeShopItemConfig config = _staticDataService.GetWeaponUpgradeShopItemConfig(typeId);

			WeaponUpgradeShopItem item = _instantiator.InstantiatePrefabForComponent<WeaponUpgradeShopItem>(config.ViewPrefab, parent);

			item.Setup(typeId);

			return item;
		}
	}
}