using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponStatsProvider
	{
		float GetFireRange(WeaponConfig config);
		float GetCooldown(WeaponConfig config);
		float GetReloadTime(WeaponConfig config);
		float GetPrechargingTime(WeaponConfig config);
		float GetMagazineSize(WeaponConfig config);
		float GetAccuracy(WeaponConfig config);
		float GetEnchantSlots(WeaponConfig config);
	}
}