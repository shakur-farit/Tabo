using Code.Meta.Features.Shop.WeaponUpgrade;
using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using Code.Progress.Provider;
using System.Collections.Generic;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponUpgradeService : IWeaponUpgradeService
	{
		private readonly Dictionary<WeaponUpgradeShopItemTypeId, float> _upgrades = new();

		private readonly IProgressProvider _progressProvider;

		public WeaponUpgradeService(IProgressProvider progressProvider) =>
			_progressProvider = progressProvider;

		public void Upgrade(WeaponUpgradeShopItemConfig config)
		{
			if (_upgrades.ContainsKey(config.TypeId))
				_upgrades[config.TypeId] += config.UpgradeValue;
			else
				_upgrades[config.TypeId] = config.UpgradeValue;
		}


		public float GetUpgradeBonus(WeaponUpgradeShopItemTypeId typeId) =>
			_upgrades.TryGetValue(typeId, out var value) ? value : 0f;

		public void RemoveUpgrades() => 
			_upgrades.Clear();

		private void SubtractPrice(int price) =>
			_progressProvider.HeroData.CurrentCoinsCount -= price;
	}
}