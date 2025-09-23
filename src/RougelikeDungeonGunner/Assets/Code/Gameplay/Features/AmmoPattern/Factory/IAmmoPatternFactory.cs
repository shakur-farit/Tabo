using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Gameplay.Features.AmmoPattern.Factory
{
	public interface IAmmoPatternFactory
	{
		GameEntity CreatePattern(AmmoPatternSetup patternSetup, AmmoTypeId ammoType,
			Vector3 origin, Vector3 forward);
	}
}