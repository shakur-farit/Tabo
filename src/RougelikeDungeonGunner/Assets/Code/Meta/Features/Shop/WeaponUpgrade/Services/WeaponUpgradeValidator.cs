using Code.Common.Balance;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Configs;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgradeValidator : IWeaponUpgradeValidator
	{
		public const float MaxAccuracyInPercent = 100f;

		private readonly IWeaponStatsProvider _statsProvider;
		private readonly IStaticDataService _staticDataService;
		private readonly ICurrentHeroWeaponProvider _heroWeapon;


		public WeaponUpgradeValidator(
			IWeaponStatsProvider statsProvider,
			ICurrentHeroWeaponProvider heroWeapon,
			IStaticDataService staticDataService)
		{
			_statsProvider = statsProvider;
			_staticDataService = staticDataService;
			_heroWeapon = heroWeapon;
		}

		public bool CanUpgrade(WeaponUpgradeShopItemConfig config)
		{
			WeaponBalance weaponBalance = _staticDataService.GetBalance().WeaponBalance;

			WeaponTypeId currentWeapon = _heroWeapon.CurrentWeaponTypeId;
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
        case WeaponUpgradeTypeId.CurrentBullets:
          float bullets = _statsProvider.GetCurrentBulletsCount(weaponConfig);
          return bullets + config.UpgradeValue <= _statsProvider.GetMaxAmmoCount(weaponConfig);
        case WeaponUpgradeTypeId.CurrentMissiles:
          float missiles = _statsProvider.GetCurrentMissilesCount(weaponConfig);
          return missiles + config.UpgradeValue <= _statsProvider.GetMaxAmmoCount(weaponConfig);
        default:
					return true;
			}
		}
	}
}