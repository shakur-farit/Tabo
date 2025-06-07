using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponStatsProvider : IWeaponStatsProvider
	{
		private const float GLOBAL_MIN = -100f;
		private const float GLOBAL_MAX = 100f;
		private const float GLOBAL_SPREAD = GLOBAL_MAX - GLOBAL_MIN;

		private readonly IWeaponUpgradeService _upgradeService;

		public WeaponStatsProvider(IWeaponUpgradeService upgradeService) => 
			_upgradeService = upgradeService;


		public float GetFireRange(WeaponConfig config) => 
			config.Stats.FireRange + _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.FireRange);

		public float GetCooldown(WeaponConfig config) => 
			config.Stats.Cooldown  - _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.Cooldown);
		
		public float GetReloadTime(WeaponConfig config) =>
			config.Stats.ReloadTime - _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.ReloadTime);

		public float GetPrechargingTime(WeaponConfig config) =>
			config.Stats.PrechargingTime - _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.PrechargingTime);

		public float GetMagazineSize(WeaponConfig config) =>
			config.Stats.MagazineSize + _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.MagazineSize);

		public float GetAccuracy(WeaponConfig config)
		{
			float min = config.Stats.MinSpreadAngle;
			float max = config.Stats.MaxSpreadAngle;

			float spread = Mathf.Abs(max - min);

			float baseAccuracy01 = 1f - (spread / 200f);

			float accuracyBonusPercent = _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.Accuracy);
			float upgradedAccuracy01 = baseAccuracy01 + (accuracyBonusPercent / 100f);

			return Mathf.Clamp(upgradedAccuracy01 * 100f, 0f, 100f);
		}

		public float GetEnchantSlots(WeaponConfig config) =>
			config.Stats.EnchantSlots + _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.EnchantSlots);

		public float GetMinSpreadAngle(WeaponConfig config)
		{
			float accuracy = GetAccuracy(config);
			float actualSpread = GLOBAL_SPREAD * (1 - accuracy);
			float center = (config.Stats.MinSpreadAngle + config.Stats.MaxSpreadAngle) / 2f;
			return center - actualSpread / 2f;
		}

		public float GetMaxSpreadAngle(WeaponConfig config)
		{
			float accuracy = GetAccuracy(config);
			float actualSpread = GLOBAL_SPREAD * (1 - accuracy);
			float center = (config.Stats.MinSpreadAngle + config.Stats.MaxSpreadAngle) / 2f;
			return center + actualSpread / 2f;
		}
	}
}