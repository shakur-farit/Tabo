using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Progress.Provider;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgradeValidator : IWeaponUpgradeValidator
	{
		private readonly IWeaponStatsProvider _statsProvider;
		private readonly IProgressProvider _progressProvider;
		private readonly IStaticDataService _staticDataService;

		public WeaponUpgradeValidator(
			IWeaponStatsProvider statsProvider,
			IProgressProvider progressProvider,
			IStaticDataService staticDataService)
		{
			_statsProvider = statsProvider;
			_progressProvider = progressProvider;
			_staticDataService = staticDataService;
		}

		public bool CanUpgrade(WeaponUpgradeShopItemConfig config)
		{
			var currentWeapon = _progressProvider.HeroData.CurrentWeaponTypeId;
			var weaponConfig = _staticDataService.GetWeaponConfig(currentWeapon);

			switch (config.TypeId)
			{
				case WeaponUpgradeShopItemTypeId.Cooldown:
					float cooldown = _statsProvider.GetCooldown(weaponConfig);
					return cooldown - config.UpgradeValue >= 0.1f;

				case WeaponUpgradeShopItemTypeId.ReloadTime:
					float reload = _statsProvider.GetReloadTime(weaponConfig);
					return reload - config.UpgradeValue >= 0.1f;

				case WeaponUpgradeShopItemTypeId.PrechargingTime:
					float precharge = _statsProvider.GetPrechargingTime(weaponConfig);
					return precharge - config.UpgradeValue >= 0.1f;

				case WeaponUpgradeShopItemTypeId.Accuracy:
					float accuracy = _statsProvider.GetAccuracy(weaponConfig);
					return accuracy + config.UpgradeValue <= 100f;

				case WeaponUpgradeShopItemTypeId.EnchantSlots:
					float slots = _statsProvider.GetEnchantSlots(weaponConfig);
					return slots + config.UpgradeValue <= 10f;

				default:
					return true;
			}
		}
	}
}