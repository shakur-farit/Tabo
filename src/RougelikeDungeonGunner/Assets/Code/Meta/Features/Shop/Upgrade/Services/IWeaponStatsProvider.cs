using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public interface IWeaponStatsProvider
	{
		float GetFireRange(WeaponConfig config);
		float GetCooldown(WeaponConfig config);
	}
}