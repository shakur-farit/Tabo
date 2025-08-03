using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Services
{
	public interface IAmmoSpawnPatternService
	{
		void SpawnAmmoPattern(AmmoPattern pattern, AmmoTypeId ammoType,
			Vector3 origin, Vector3 forward, int producerId);
	}
}