using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public interface IWeaponFactory
	{
		GameEntity CreateWeapon(WeaponTypeId weaponTypeId, int level, GameEntity parentEntity, Vector2 at);
	}
}