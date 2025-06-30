using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using UnityEngine;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponStatsProvider : IWeaponStatsProvider
	{
		private readonly IWeaponUpgradesProvider _provider;
		private readonly IStaticDataService _staticDataService;

		public WeaponStatsProvider(IWeaponUpgradesProvider provider, IStaticDataService staticDataService)
		{
			_provider = provider;
			_staticDataService = staticDataService;
		}

		public float GetFireRange(WeaponConfig config) => 
			config.Stats.FireRange + _provider.GetUpgradeBonus(WeaponUpgradeTypeId.FireRange);

		public float GetCooldown(WeaponConfig config) => 
			config.Stats.Cooldown  - _provider.GetUpgradeBonus(WeaponUpgradeTypeId.Cooldown);
		
		public float GetReloadTime(WeaponConfig config) =>
			config.Stats.ReloadTime - _provider.GetUpgradeBonus(WeaponUpgradeTypeId.ReloadTime);

		public float GetPrechargingTime(WeaponConfig config) =>
			config.Stats.PrechargingTime - _provider.GetUpgradeBonus(WeaponUpgradeTypeId.PrechargingTime);

		public int GetMagazineSize(WeaponConfig config) =>
			config.Stats.MagazineSize + (int)_provider.GetUpgradeBonus(WeaponUpgradeTypeId.MagazineSize);

		public int GetPierce(WeaponConfig config) =>
			config.Stats.Pierce + (int)_provider.GetUpgradeBonus(WeaponUpgradeTypeId.Pierce);

		public float GetAccuracy(WeaponConfig config) => 
			config.Stats.Accuracy + _provider.GetUpgradeBonus(WeaponUpgradeTypeId.Accuracy);

		public int GetEnchantSlots(WeaponConfig config) =>
			config.Stats.EnchantSlots + (int)_provider.GetUpgradeBonus(WeaponUpgradeTypeId.EnchantSlots);

		public float GetMinDeviation(WeaponConfig config) => 
			-GetHalfSpread(GetAccuracy(config));

		public float GetMaxDeviation(WeaponConfig config) => 
			GetHalfSpread(GetAccuracy(config));

		private float GetHalfSpread(float accuracy)
		{
			accuracy = Mathf.Clamp01(accuracy/100f);
			float spread = _staticDataService.GetBalance().WeaponBalance.MaxSpreadAngle * (1f - accuracy);
			return spread * 0.5f;
		}
	}
}