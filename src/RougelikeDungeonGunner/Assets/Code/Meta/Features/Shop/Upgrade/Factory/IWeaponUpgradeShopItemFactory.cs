using Code.Meta.Features.Shop.Upgrade.Beahaviours;
using Code.Meta.Features.Shop.Upgrade.Configs;
using UnityEngine;

namespace Code.Meta.Features.Shop.Upgrade.Factory
{
	public interface IWeaponUpgradeShopItemFactory
	{
		WeaponUpgradeShopItem CreateUpgradeWeaponShopItem(WeaponUpgradeShopItemConfig config, Transform parent);
	}
}