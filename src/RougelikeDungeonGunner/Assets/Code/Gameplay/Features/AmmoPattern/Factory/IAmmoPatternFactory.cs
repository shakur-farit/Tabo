using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	public interface IAmmoPatternFactory
	{
		GameEntity CreatePattern(AmmoPatternSetup patternSetup, AmmoTypeId ammoType,
			Vector3 origin, Vector3 forward);
	}
}