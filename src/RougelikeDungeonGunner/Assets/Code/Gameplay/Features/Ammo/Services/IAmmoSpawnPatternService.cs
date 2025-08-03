using Code.Gameplay.Features.Ammo.Factory;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Services
{
	public interface IAmmoSpawnPatternService
	{
		void SpawnAmmoPattern(AmmoPatternTypeId patternType, AmmoTypeId ammoType,
			Vector3 origin, Vector3 forward, int producerId);
	}
}