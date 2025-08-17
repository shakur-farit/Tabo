using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using Entitas;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	[Game] public class Weapon : IComponent { }
	[Game] public class WeaponTypeIdComponent : IComponent { public WeaponTypeId Value; }
	[Game] public class WeaponOwnerId : IComponent { public int Value; }
	[Game] public class WeaponOwnerTypeIdComponent : IComponent { public WeaponOwnerTypeId Value; }
	[Game] public class HeroWeapon : IComponent { }
	[Game] public class EnemyWeapon : IComponent { }

	[Game] public class ClosestTargetPosition : IComponent { public Vector3 Value; }

	[Game] public class FirePositionTransform : IComponent { public Transform Value; }
	[Game] public class WeaponRotationPointTransform : IComponent { public Transform Value; }
	[Game] public class WeaponRotationAngle : IComponent { public float Value; }

	[Game] public class ReloadTime : IComponent { public float Value; }
	[Game] public class ReloadTimeLeft : IComponent { public float Value; }
	[Game] public class MagazineSize : IComponent { public int Value; }
	[Game] public class Pierce : IComponent { public int Value; }
	[Game] public class InfinityAmmo : IComponent { }
	[Game] public class CurrentAmmoCount : IComponent { public int Value; }
	[Game] public class MagazineNotEmpty : IComponent { }
	[Game] public class MultiPellet : IComponent { public int Value; }
	[Game] public class MinPelletsDeviation : IComponent { public float Value; }
	[Game] public class MaxPelletsDeviation : IComponent { public float Value; }
	[Game] public class PrechargeTime : IComponent { public float Value; }
	[Game] public class PrechargeTimeLeft : IComponent { public float Value; }
	
	[Game] public class Shot : IComponent { }
	[Game] public class ReadyToShoot : IComponent { }
	[Game] public class Precharged : IComponent { }
	[Game] public class Shooting : IComponent { }
	[Game] public class Reloading : IComponent { }

	[Game] public class EffectSetups : IComponent { public List<EffectSetup> Value; }
	[Game] public class StatusSetups : IComponent { public List<StatusSetup> Value; }

	[Game] public class WeaponEnchants : IComponent { public Dictionary<int, StatusSetup> Value; }
	[Game] public class MaxWeaponEnchantsCount : IComponent { public int Value; }

	[Game] public class HeroPistol : IComponent { }
	[Game] public class HeroRevolver : IComponent { }
	[Game] public class HeroShotgun : IComponent { }
	[Game] public class HeroAutomaticPistol : IComponent { }
	[Game] public class HeroMachinegun : IComponent { }
	[Game] public class HeroSniper : IComponent { }
	[Game] public class HeroPlasmaGun : IComponent { }
	[Game] public class HeroLaserBlaster : IComponent { }
	[Game] public class HeroRocketLauncher : IComponent { }
	[Game] public class EnemyPistol : IComponent { }
	[Game] public class CircleSigil : IComponent { }
	[Game] public class TriangleSigil : IComponent { }
	[Game] public class StarSigil : IComponent { }
}