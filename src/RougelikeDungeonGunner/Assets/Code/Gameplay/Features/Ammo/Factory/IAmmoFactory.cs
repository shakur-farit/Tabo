using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Factory
{
	public interface IAmmoFactory
	{
		GameEntity CreatePistolBullet(int level, Vector3 at);
	}
}