using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public interface IWeaponFactory
	{
		GameEntity CreateWeapon(WeaponId weaponId, int level, GameEntity entity, Vector2 at);
	}
}