using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
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