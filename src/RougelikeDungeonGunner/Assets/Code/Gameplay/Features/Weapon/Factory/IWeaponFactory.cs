using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public interface IWeaponFactory
	{
		GameEntity CreateWeapon(WeaponId weaponId, int level, GameEntity parentEntity, Vector2 at);
	}
}