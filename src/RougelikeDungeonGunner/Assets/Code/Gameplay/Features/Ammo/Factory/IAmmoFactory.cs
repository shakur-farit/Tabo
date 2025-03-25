using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Factory
{
	public interface IAmmoFactory
	{
		GameEntity CreateAmmo(AmmoTypeId ammoTypeId, int level, Vector3 at);
	}
}