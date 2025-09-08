using System.Collections.Generic;
using Code.Gameplay.Features.Weapon;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponUpgradesProvider
	{
		float GetUpgradeBonus(WeaponTypeId weaponTypeId, WeaponUpgradeTypeId upgradeTypeId);
		void AddUpgrade(WeaponUpgradeTypeId typeId, float value);
	}

	public interface IWeaponUpgradesCleaner
	{
		void CleanUpgrades();
	}
}