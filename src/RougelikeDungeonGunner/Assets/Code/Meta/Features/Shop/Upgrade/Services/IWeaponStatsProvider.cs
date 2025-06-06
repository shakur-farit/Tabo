using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public interface IWeaponStatsProvider
	{
		float GetFireRange(WeaponConfig config);
	}
}