using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.Features.Weapon.Services;
using Code.Gameplay.StaticData;
using UnityEngine;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponStatsProvider : IWeaponStatsProvider
	{
		private readonly IWeaponUpgradesProvider _provider;
		private readonly IStaticDataService _staticDataService;
    private readonly IAmmoCountProvider _ammoCount;

    public WeaponStatsProvider(IWeaponUpgradesProvider provider, IStaticDataService staticDataService, IAmmoCountProvider ammoCount)
		{
			_provider = provider;
			_staticDataService = staticDataService;
      _ammoCount = ammoCount;
    }

		public float GetFireRange(WeaponConfig config) => 
			config.Stats.FireRange + _provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.FireRange);

		public float GetCooldown(WeaponConfig config) => 
			config.Stats.Cooldown  - _provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.Cooldown);
		
		public float GetReloadTime(WeaponConfig config) =>
			config.Stats.ReloadTime - _provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.ReloadTime);

		public float GetPrechargingTime(WeaponConfig config) =>
			config.Stats.PrechargingTime - _provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.PrechargingTime);

		public int GetMagazineSize(WeaponConfig config) =>
			config.Stats.MagazineSize + (int)_provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.MagazineSize);

		public int GetMaxAmmoCount(WeaponConfig config) =>
			config.Stats.MaxAmmoCount + (int)_provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.MaxAmmoCount);

    public int GetCurrentBulletsCount(WeaponConfig config) => 
      _ammoCount.GetCurrentAmmoCount(config) + (int)_provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.CurrentBullets);

    public int GetCurrentMissilesCount(WeaponConfig config) => 
      _ammoCount.GetCurrentAmmoCount(config) + (int)_provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.CurrentMissiles);

    public int GetPierce(WeaponConfig config) =>
			config.Stats.Pierce + (int)_provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.Pierce);

		public float GetAccuracy(WeaponConfig config) => 
			config.Stats.Accuracy + _provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.Accuracy);

		public int GetEnchantSlots(WeaponConfig config) =>
			config.Stats.EnchantSlots + (int)_provider.GetUpgradeBonus(config.TypeId, WeaponUpgradeTypeId.EnchantSlots);

		public float GetMinDeviation(WeaponConfig config) => 
			-GetHalfSpread(GetAccuracy(config));

		public float GetMaxDeviation(WeaponConfig config) => 
			GetHalfSpread(GetAccuracy(config));

		private float GetHalfSpread(float accuracy)
		{
			accuracy = Mathf.Clamp01(accuracy/100f);
			float spread = _staticDataService.GetGameBalance().WeaponBalance.MaxSpreadAngle * (1f - accuracy);
			return spread * 0.5f;
		}
	}
}