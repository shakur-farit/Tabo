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
			_progressProvider.WeaponData.FireRange += config.UpgareValue;
			SubtractPrice(config.Price);
		}

		private void UpgradeCooldown(WeaponUpgradeShopItemConfig config)
		{
			if (_progressProvider.WeaponData.Cooldown <= MinValue)
				return;

			_progressProvider.WeaponData.Cooldown = Mathf.Max(
				0,
				_progressProvider.WeaponData.Cooldown - config.UpgareValue);

			SubtractPrice(config.Price);
		}

		private void UpgradeReloadTime(WeaponUpgradeShopItemConfig config)
		{
			if (_progressProvider.WeaponData.ReloadTime <= MinValue)
				return;

			_progressProvider.WeaponData.ReloadTime = Mathf.Max(
				0,
				_progressProvider.WeaponData.ReloadTime - config.UpgareValue);

			SubtractPrice(config.Price);
		}

		private void UpgradePrechargingTime(WeaponUpgradeShopItemConfig config)
		{
			if (_progressProvider.WeaponData.PrechargingTime <= MinValue)
				return;

			_progressProvider.WeaponData.PrechargingTime = Mathf.Max(
				0,
				_progressProvider.WeaponData.PrechargingTime - config.UpgareValue);

			SubtractPrice(config.Price);
		}

		private void UpgradeMagazineSize(WeaponUpgradeShopItemConfig config)
		{
			_progressProvider.WeaponData.MagazineSize += (int)config.UpgareValue;
			SubtractPrice(config.Price);
		}

		private void UpgradeAccuracy(WeaponUpgradeShopItemConfig config)
		{
			if (_progressProvider.WeaponData.Accuracy >= MaxAccuracyValue)
			{
				_progressProvider.WeaponData.Accuracy = MaxAccuracyValue;
				return;
			}

			_progressProvider.WeaponData.Accuracy += config.UpgareValue;
			SubtractPrice(config.Price);
		}

		private void UpgradeEnchantSlots(WeaponUpgradeShopItemConfig config)
		{
			_progressProvider.WeaponData.MaxEnchantsCount += (int)config.UpgareValue;
			SubtractPrice(config.Price);
		}

		private void SubtractPrice(int price) =>
			_progressProvider.HeroData.CurrentCoinsCount -= price;
	}
}