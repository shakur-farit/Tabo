using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponStatsProvider : IWeaponStatsProvider
	{
		private readonly IStaticDataService _staticDataService;

		public WeaponStatsProvider(IStaticDataService staticDataService)
		{
			_staticDataService = staticDataService;
		}

		public WeaponStats GetStats(WeaponTypeId id)
		{
			var config = _staticDataService.GetWeaponConfig(id);
			var baseStats = config.Stats;

			WeaponStats newStats = new WeaponStats()
			{
				FireRange = baseStats.FireRange,
				Cooldown = baseStats.Cooldown,
				ReloadTime = baseStats.ReloadTime,
				PrechargingTime = baseStats.PrechargingTime,
				MagazineSize = baseStats.MagazineSize,
				MinSpreadAngle = baseStats.MinSpreadAngle,
				MaxSpreadAngle = baseStats.MaxSpreadAngle,
				MaxEnchantsCount = baseStats.MaxEnchantsCount
			};

			return newStats;
		}
	}
}