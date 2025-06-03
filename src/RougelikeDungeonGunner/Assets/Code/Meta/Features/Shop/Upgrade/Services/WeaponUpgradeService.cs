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
			if(config.Price > _progressProvider.HeroData.CurrentCoinsCount)
				return;

			switch (config.TypeId)
			{
				case WeaponUpgradeShopItemTypeId.FireRange:
					UpgradeFireRange(config.UpgareValue);
					break;
				case WeaponUpgradeShopItemTypeId.Cooldown:
					UpgradeCooldown(config.UpgareValue);
					break;
				case WeaponUpgradeShopItemTypeId.ReloadTime:
					UpgradeReloadTime(config.UpgareValue);
					break;
				case WeaponUpgradeShopItemTypeId.PrechargingTime:
					UpgradePrechargingTime(config.UpgareValue);
					break;
				case WeaponUpgradeShopItemTypeId.MagazineSize:
					UpgradeMagazineSize(config.UpgareValue);
					break;
				case WeaponUpgradeShopItemTypeId.Accuracy:
					UpgradeAccuracy(config.UpgareValue);
					break;
				case WeaponUpgradeShopItemTypeId.EnchantSlots:
					UpgradeEnchantSlots(config.UpgareValue);
					break;
			}

			SubtractPrice(config.Price);
		}

		private void UpgradeFireRange(float upgradeValue) =>
			_progressProvider.WeaponData.FireRange += upgradeValue;

		private void UpgradeCooldown(float upgradeValue)
		{
			if (_progressProvider.WeaponData.Cooldown <= MinValue)
				return;

			_progressProvider.WeaponData.Cooldown = Mathf.Max(
				0,
				_progressProvider.WeaponData.Cooldown - upgradeValue);
		}

		private void UpgradeReloadTime(float upgradeValue)
		{
			if (_progressProvider.WeaponData.ReloadTime <= MinValue)
				return;

			_progressProvider.WeaponData.ReloadTime = Mathf.Max(
				0,
				_progressProvider.WeaponData.ReloadTime - upgradeValue);
		}

		private void UpgradePrechargingTime(float upgradeValue)
		{
			if (_progressProvider.WeaponData.PrechargingTime <= MinValue)
				return;

			_progressProvider.WeaponData.PrechargingTime = Mathf.Max(
				0,
				_progressProvider.WeaponData.PrechargingTime - upgradeValue);
		}

		private void UpgradeMagazineSize(float upgradeValue) =>
			_progressProvider.WeaponData.MagazineSize += (int)upgradeValue;

		private void UpgradeAccuracy(float upgradeValue)
		{
			if (_progressProvider.WeaponData.Accuracy >= MaxAccuracyValue)
			{
				_progressProvider.WeaponData.Accuracy = MaxAccuracyValue;
				return;
			}

			_progressProvider.WeaponData.Accuracy += upgradeValue;
		}

		private void UpgradeEnchantSlots(float upgradeValue) =>
			_progressProvider.WeaponData.MaxEnchantsCount += (int)upgradeValue;

		private void SubtractPrice(int price) =>
			_progressProvider.HeroData.CurrentCoinsCount -= price;
	}
}