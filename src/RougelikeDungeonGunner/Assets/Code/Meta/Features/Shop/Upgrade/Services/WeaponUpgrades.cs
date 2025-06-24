using System.Collections.Generic;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgrades : IWeaponUpgradesProvider, IWeaponUpgradesCleaner
	{
		private readonly Dictionary<WeaponUpgradeTypeId, float> _upgrades = new();

		public float GetUpgradeBonus(WeaponUpgradeTypeId typeId) =>
			_upgrades.TryGetValue(typeId, out var value) ? value : 0f;

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