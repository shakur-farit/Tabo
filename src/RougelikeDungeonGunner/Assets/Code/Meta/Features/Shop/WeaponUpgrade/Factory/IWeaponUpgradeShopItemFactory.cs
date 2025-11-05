using Code.Meta.Features.Shop.WeaponUpgrade.Beahaviours;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponUpgrade.Factory
{
	public interface IWeaponUpgradeShopItemFactory
	{
		WeaponUpgradeShopItem CreateUpgradeWeaponShopItem(WeaponUpgradeTypeId typeId, Transform parent);
	}
}