using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public interface IWeaponFactory
	{
		GameEntity CreateWeapon(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId);
	}
}