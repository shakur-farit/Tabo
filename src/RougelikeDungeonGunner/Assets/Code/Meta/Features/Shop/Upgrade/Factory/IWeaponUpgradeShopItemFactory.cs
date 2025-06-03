using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public interface IWeaponUpgradeShopItemFactory
	{
		WeaponUpgradeShopItem CreateUpgradeWeaponShopItem(WeaponUpgradeShopItemConfig config, Transform parent);
	}
}