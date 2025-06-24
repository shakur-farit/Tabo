using System.Collections.Generic;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponUpgradesProvider
	{
		float GetUpgradeBonus(WeaponUpgradeTypeId typeId);
		void AddUpgrade(WeaponUpgradeTypeId typeId, float value);
	}

	public interface IWeaponUpgradesCleaner
	{
		void CleanUpgrades();
	}
}