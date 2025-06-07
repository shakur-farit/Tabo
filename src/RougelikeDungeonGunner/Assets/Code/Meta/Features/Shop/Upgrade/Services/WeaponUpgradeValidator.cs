using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Progress.Provider;
using UnityEngine;

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
					float currentCooldown = _statsProvider.GetCooldown(weaponConfig);
					float newCooldown = Mathf.Max(0.1f, currentCooldown - config.UpgradeValue);
					return newCooldown >= 0.1f;

				default:
					return true;
			}
		}
	}
}