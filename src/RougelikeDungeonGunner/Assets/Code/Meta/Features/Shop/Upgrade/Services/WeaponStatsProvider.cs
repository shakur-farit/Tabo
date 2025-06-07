using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponStatsProvider : IWeaponStatsProvider
	{
		private const float GLOBAL_MIN = -100f;
		private const float GLOBAL_MAX = 100f;
		private const float GLOBAL_SPREAD = GLOBAL_MAX - GLOBAL_MIN;

		private readonly IWeaponUpgradesProvider _provider;

		public WeaponStatsProvider(IWeaponUpgradesProvider provider) => 
			_provider = provider;


		public float GetFireRange(WeaponConfig config) => 
			config.Stats.FireRange + _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.FireRange);

		public float GetCooldown(WeaponConfig config) => 
			config.Stats.Cooldown  - _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.Cooldown);
		
		public float GetReloadTime(WeaponConfig config) =>
			config.Stats.ReloadTime - _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.ReloadTime);

		public float GetPrechargingTime(WeaponConfig config) =>
			config.Stats.PrechargingTime - _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.PrechargingTime);

		public int GetMagazineSize(WeaponConfig config) =>
			config.Stats.MagazineSize + (int)_provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.MagazineSize);

		public float GetAccuracy(WeaponConfig config)
		{
			float min = config.Stats.MinSpreadAngle;
			float max = config.Stats.MaxSpreadAngle;

			float spread = Mathf.Abs(max - min);

			float baseAccuracy01 = 1f - (spread / 200f);

			float accuracyBonusPercent = _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.Accuracy);
			float upgradedAccuracy01 = baseAccuracy01 + (accuracyBonusPercent / 100f);

			float clamped = Mathf.Clamp01(upgradedAccuracy01);

			return Mathf.Lerp(-100f, 100f, clamped);
		}

		public int GetEnchantSlots(WeaponConfig config) =>
			config.Stats.EnchantSlots + (int)_provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.EnchantSlots);

		public float GetMinSpreadAngle(WeaponConfig config)
		{
			float rawAccuracy = GetAccuracy(config);
			float normalizedAccuracy = Mathf.InverseLerp(GLOBAL_MIN, GLOBAL_MAX, rawAccuracy);

			float min = config.Stats.MinSpreadAngle;
			float max = config.Stats.MaxSpreadAngle;

			float fullSpread = max - min;
			float reducedSpread = fullSpread * (1f - normalizedAccuracy);
			float center = (min + max) / 2f;

			return center - reducedSpread / 2f;
		}

		public float GetMaxSpreadAngle(WeaponConfig config)
		{
			float rawAccuracy = GetAccuracy(config);
			float normalizedAccuracy = Mathf.InverseLerp(GLOBAL_MIN, GLOBAL_MAX, rawAccuracy); 

			float min = config.Stats.MinSpreadAngle;
			float max = config.Stats.MaxSpreadAngle;

			float fullSpread = max - min;
			float reducedSpread = fullSpread * (1f - normalizedAccuracy);
			float center = (min + max) / 2f;

			return center + reducedSpread / 2f;
		}
	}
}