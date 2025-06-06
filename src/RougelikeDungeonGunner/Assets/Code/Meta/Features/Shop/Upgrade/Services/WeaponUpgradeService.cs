using Code.Meta.Features.Shop.WeaponUpgrade;
using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using Code.Progress.Provider;
using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponUpgradeService : IWeaponUpgradeService
	{
		private const int MaxAccuracyValue = 100;
		private const int MinValue = 0;

		private readonly IProgressProvider _progressProvider;

		public WeaponUpgradeService(IProgressProvider progressProvider) =>
			_progressProvider = progressProvider;

		public void Upgrade(WeaponUpgradeShopItemConfig config)
		{
			if (config.Price > _progressProvider.HeroData.CurrentCoinsCount)
				return;

			switch (config.TypeId)
			{
				case WeaponUpgradeShopItemTypeId.FireRange:
					UpgradeFireRange(config);
					break;
				case WeaponUpgradeShopItemTypeId.Cooldown:
					UpgradeCooldown(config);
					break;
				case WeaponUpgradeShopItemTypeId.ReloadTime:
					UpgradeReloadTime(config);
					break;
				case WeaponUpgradeShopItemTypeId.PrechargingTime:
					UpgradePrechargingTime(config);
					break;
				case WeaponUpgradeShopItemTypeId.MagazineSize:
					UpgradeMagazineSize(config);
					break;
				case WeaponUpgradeShopItemTypeId.Accuracy:
					UpgradeAccuracy(config);
					break;
				case WeaponUpgradeShopItemTypeId.EnchantSlots:
					UpgradeEnchantSlots(config);
					break;
			}
		}

		private void UpgradeFireRange(WeaponUpgradeShopItemConfig config)
		{
			SubtractPrice(config.Price);
		}

		private void UpgradeCooldown(WeaponUpgradeShopItemConfig config)
		{
			
			SubtractPrice(config.Price);
		}

		private void UpgradeReloadTime(WeaponUpgradeShopItemConfig config)
		{
			SubtractPrice(config.Price);
		}

		private void UpgradePrechargingTime(WeaponUpgradeShopItemConfig config)
		{
			SubtractPrice(config.Price);
		}

		private void UpgradeMagazineSize(WeaponUpgradeShopItemConfig config)
		{
			SubtractPrice(config.Price);
		}

		private void UpgradeAccuracy(WeaponUpgradeShopItemConfig config)
		{
			SubtractPrice(config.Price);
		}

		private void UpgradeEnchantSlots(WeaponUpgradeShopItemConfig config)
		{
			SubtractPrice(config.Price);
		}

		private void SubtractPrice(int price) =>
			_progressProvider.HeroData.CurrentCoinsCount -= price;
	}
}