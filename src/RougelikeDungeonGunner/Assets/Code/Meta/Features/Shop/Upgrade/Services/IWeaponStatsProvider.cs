using Assets.Code.Gameplay.Features.Weapon.Configs;

namespace Assets.Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponStatsProvider
	{
		float GetFireRange(WeaponConfig config);
		float GetCooldown(WeaponConfig config);
		float GetReloadTime(WeaponConfig config);
		float GetPrechargingTime(WeaponConfig config);
		int GetMagazineSize(WeaponConfig config);
		float GetAccuracy(WeaponConfig config);
		int GetEnchantSlots(WeaponConfig config);
		float GetMinDeviation(WeaponConfig config);
		float GetMaxDeviation(WeaponConfig config);
		int GetPierce(WeaponConfig config);
	}
}