using System.Collections.Generic;
using System.Threading;
using Code.Gameplay.Features.Weapon;
using Code.Progress.Provider;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgrades : IWeaponUpgradesProvider, IWeaponUpgradesCleaner
	{
		private const float ZeroUpgrade = 0f;
		private readonly IProgressProvider _progressProvider;
		private readonly Dictionary<WeaponUpgradeTypeId, float> _upgrades = new();

		public WeaponUpgrades(IProgressProvider progressProvider) =>
			_progressProvider = progressProvider;

		public float GetUpgradeBonus(WeaponTypeId weaponTypeId, WeaponUpgradeTypeId upgradeTypeId)
		{
			if (weaponTypeId == _progressProvider.HeroData.CurrentWeaponTypeId)
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