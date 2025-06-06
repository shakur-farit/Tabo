using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.WeaponUpgrade;
using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponStatsProvider : IWeaponStatsProvider
	{
		private readonly IWeaponUpgradeService _upgradeService;

		public WeaponStatsProvider(IWeaponUpgradeService upgradeService)
		{
			_upgradeService = upgradeService;
		}


		public float GetFireRange(WeaponConfig config) => 
			config.Stats.FireRange + _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.FireRange);

		public float GetCooldown(WeaponConfig config)
		{
			float baseValue = config.Stats.Cooldown;
			float bonus = _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.Cooldown);
			return Mathf.Max(0.1f, baseValue - bonus);
		}
	}
}