using Code.Meta.Features.Shop.Upgrade.Beahaviours;
using Code.Meta.Features.Shop.Upgrade.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.Upgrade.Factory
{
	public class WeaponUpgradeShopItemFactory : IWeaponUpgradeShopItemFactory
	{
		private readonly IInstantiator _instantiator;

		public WeaponUpgradeShopItemFactory(IInstantiator instantiator) =>
			_instantiator = instantiator;

		public WeaponUpgradeShopItem CreateUpgradeWeaponShopItem(WeaponUpgradeShopItemConfig config, Transform parent) =>
			_instantiator.InstantiatePrefabForComponent<WeaponUpgradeShopItem>(config.ViewPrefab, parent);
	}
}