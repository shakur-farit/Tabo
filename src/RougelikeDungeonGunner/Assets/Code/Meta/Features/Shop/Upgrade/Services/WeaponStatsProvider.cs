using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Meta.Features.Shop.Upgrade.Services
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

		public float GetCooldown(WeaponConfig config) => 
			config.Stats.Cooldown  - _upgradeService.GetUpgradeBonus(WeaponUpgradeShopItemTypeId.Cooldown);
	}
}