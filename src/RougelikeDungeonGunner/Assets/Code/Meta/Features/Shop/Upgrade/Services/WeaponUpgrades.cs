using System.Collections.Generic;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Weapon;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgrades : IWeaponUpgradesProvider, IWeaponUpgradesCleaner
	{
		private const float ZeroUpgrade = 0f;
		private readonly Dictionary<WeaponUpgradeTypeId, float> _upgrades = new();

		private readonly ICurrentHeroWeaponProvider _heroWeapon;

		public WeaponUpgrades(ICurrentHeroWeaponProvider heroWeapon) => 
			_heroWeapon = heroWeapon;

		public float GetUpgradeBonus(WeaponTypeId weaponTypeId, WeaponUpgradeTypeId upgradeTypeId)
		{
			if (weaponTypeId == _heroWeapon.CurrentWeaponTypeId)
				return _upgrades.TryGetValue(upgradeTypeId, out var value) ? value : ZeroUpgrade;
				
			return ZeroUpgrade;
		}

		public void AddUpgrade(WeaponUpgradeTypeId typeId, float value)
		{
			if (_upgrades.ContainsKey(typeId))
				_upgrades[typeId] += value;
			else
				_upgrades[typeId] = value;
		}

		public void CleanUpgrades() => _upgrades.Clear();
	}
}