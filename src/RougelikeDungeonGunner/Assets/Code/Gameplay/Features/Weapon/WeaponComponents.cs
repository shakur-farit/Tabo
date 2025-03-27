using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	[Game] public class Weapon : IComponent { }
	[Game] public class WeaponTypeIdComponent : IComponent { public WeaponTypeId Value; }

	[Game] public class ClosestTargetPosition : IComponent { public Vector3 Value; }

	[Game] public class FirePositionTransform : IComponent { public Transform Value; }
	[Game] public class WeaponRotationPointTransform : IComponent { public Transform Value; }
	[Game] public class WeaponSpriteRenderer : IComponent { public SpriteRenderer Value; }
	[Game] public class WeaponRotationAngle : IComponent { public float Value; }

	[Game] public class ReloadTime : IComponent { public float Value; }
	[Game] public class ReloadTimeLeft : IComponent { public float Value; }
	[Game] public class MagazineSize : IComponent { public int Value; }
	[Game] public class CurrentAmmoAmount : IComponent { public int Value; }
	[Game] public class MagazineNotEmpty : IComponent { }
	[Game] public class MultiPellet : IComponent { public int Value; }
	[Game] public class MinPelletsSpreadAngle : IComponent { public float Value; }
	[Game] public class MaxPelletsSpreadAngle : IComponent { public float Value; }
	[Game] public class PrechargeTime : IComponent { public float Value; }
	[Game] public class PrechargeTimeLeft : IComponent { public float Value; }
	
	[Game] public class Shot : IComponent { }
	[Game] public class ReadyToShoot : IComponent { }
	[Game] public class Precharged : IComponent { }

	[Game] public class Pistol : IComponent { }
	[Game] public class Revolver : IComponent { }
	[Game] public class Shotgun : IComponent { }
	[Game] public class AutomaticPistol : IComponent { }
	[Game] public class Machinegun : IComponent { }
	[Game] public class Sniper : IComponent { }
	[Game] public class PlasmaGun : IComponent { }
	[Game] public class LaserBlaster : IComponent { }
	[Game] public class RocketLauncher : IComponent { }

}