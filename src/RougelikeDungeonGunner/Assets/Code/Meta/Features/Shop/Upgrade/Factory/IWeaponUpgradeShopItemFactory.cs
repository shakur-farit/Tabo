using Assets.Code.Meta.Features.Shop.Upgrade.Beahaviours;
using UnityEngine;

namespace Assets.Code.Meta.Features.Shop.Upgrade.Factory
{
	public interface IWeaponUpgradeShopItemFactory
	{
		WeaponUpgradeShopItem CreateUpgradeWeaponShopItem(WeaponUpgradeTypeId typeId, Transform parent);
	}
}