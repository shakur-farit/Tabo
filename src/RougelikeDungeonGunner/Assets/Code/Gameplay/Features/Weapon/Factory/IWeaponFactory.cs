using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public interface IWeaponFactory
	{
		GameEntity CreateWeapon(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at);
	}
}