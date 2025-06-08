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
			config.Stats.FireRange + _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.FireRange);

		public float GetCooldown(WeaponConfig config) => 
			config.Stats.Cooldown  - _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.Cooldown);
		
		public float GetReloadTime(WeaponConfig config) =>
			config.Stats.ReloadTime - _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.ReloadTime);

		public float GetPrechargingTime(WeaponConfig config) =>
			config.Stats.PrechargingTime - _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.PrechargingTime);

		public int GetMagazineSize(WeaponConfig config) =>
			config.Stats.MagazineSize + (int)_provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.MagazineSize);

		public float GetAccuracy(WeaponConfig config) => 
			config.Stats.Accuracy + _provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.Accuracy);

		public int GetEnchantSlots(WeaponConfig config) =>
			config.Stats.EnchantSlots + (int)_provider.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.EnchantSlots);

		public float GetMinDeviation(WeaponConfig config) => 
			-GetHalfSpread(GetAccuracy(config));

		public float GetMaxDeviation(WeaponConfig config) => 
			GetHalfSpread(GetAccuracy(config));

		private float GetHalfSpread(float accuracy)
		{
			Debug.Log(accuracy);
			accuracy = Mathf.Clamp01(accuracy/100f);
			Debug.Log(accuracy);
			float spread = _staticDataService.GetBalance().WeaponBalance.MaxSpreadAngle * (1f - accuracy);
			Debug.Log(spread);
			return spread * 0.5f;
		}
	}
}