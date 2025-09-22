using UnityEngine;

namespace Assets.Code.Gameplay.Features.Ammo.Factory
{
	public interface IAmmoFactory
	{
		GameEntity CreateAmmo(AmmoTypeId ammoTypeId, Vector3 at);
	}
}