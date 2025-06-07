using System.Collections.Generic;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Progress.Provider;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgradeService : IWeaponUpgradeService
	{
		private readonly Dictionary<WeaponUpgradeShopItemTypeId, float> _upgrades = new();

		private readonly IProgressProvider _progressProvider;
		private readonly IWeaponUpgradeValidator _validator;

		public WeaponUpgradeService(IProgressProvider progressProvider, IWeaponUpgradeValidator validator)
		{
			_progressProvider = progressProvider;
			_validator = validator;
		}

		public void Upgrade(WeaponUpgradeShopItemConfig config)
		{
			if (_upgrades.ContainsKey(config.TypeId))
			{
				if (_validator.CanUpgrade(config) == false)
					return;

				_upgrades[config.TypeId] += config.UpgradeValue;
			}
			else
				_upgrades[config.TypeId] = config.UpgradeValue;

			SubtractPrice(config.Price);
		}


		public float GetUpgradeBonus(WeaponUpgradeShopItemTypeId typeId) =>
			_upgrades.TryGetValue(typeId, out var value) ? value : 0f;

		public void RemoveUpgrades() =>
			_upgrades.Clear();

		private void SubtractPrice(int price) =>
			_progressProvider.HeroData.CurrentCoinsCount -= price;
	}
}