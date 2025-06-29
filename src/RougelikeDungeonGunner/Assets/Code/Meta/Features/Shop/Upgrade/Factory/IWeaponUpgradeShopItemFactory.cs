using Code.Meta.Features.Shop.Upgrade.Behaviours;
using UnityEngine;

namespace Code.Meta.Features.Shop.Upgrade.Factory
{
	public interface IWeaponUpgradeShopItemFactory
	{
		WeaponUpgradeShopItem CreateUpgradeWeaponShopItem(WeaponUpgradeTypeId typeId, Transform parent);
	}
}