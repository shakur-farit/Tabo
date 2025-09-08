using Code.Common;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Progress.Provider;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgradeValidator : IWeaponUpgradeValidator
	{
		public const float MaxAccuracyInPercent = 100f;

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
			WeaponBalance weaponBalance = _staticDataService.GetBalance().WeaponBalance;

			WeaponTypeId currentWeapon = _progressProvider.HeroData.CurrentWeaponTypeId;
			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(currentWeapon);

			switch (config.TypeId)
			{
				case WeaponUpgradeTypeId.Cooldown:
					float cooldown = _statsProvider.GetCooldown(weaponConfig);
					return cooldown - config.UpgradeValue >= weaponBalance.MinCooldown;

				case WeaponUpgradeTypeId.ReloadTime:
					float reload = _statsProvider.GetReloadTime(weaponConfig);
					return reload - config.UpgradeValue >= weaponBalance.MinReloadTime;

				case WeaponUpgradeTypeId.PrechargingTime:
					float precharge = _statsProvider.GetPrechargingTime(weaponConfig);
					return precharge - config.UpgradeValue >= weaponBalance.MinPrechargeTime;

				case WeaponUpgradeTypeId.Accuracy:
					float accuracy = _statsProvider.GetAccuracy(weaponConfig);
					return accuracy + config.UpgradeValue <= MaxAccuracyInPercent;

				case WeaponUpgradeTypeId.EnchantSlots:
					float slots = _statsProvider.GetEnchantSlots(weaponConfig);
					return slots + config.UpgradeValue <= weaponBalance.MaxEnchantSlots;

				default:
					return true;
			}
		}
	}
}