using System.Collections.Generic;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponUpgradesProvider
	{
		float GetUpgradeBonus(WeaponUpgradeShopItemTypeId typeId);
		void AddUpgrade(WeaponUpgradeShopItemTypeId typeId, float value);
	}

	public interface IWeaponUpgradesCleaner
	{
		void CleanUpgrades();
	}
}