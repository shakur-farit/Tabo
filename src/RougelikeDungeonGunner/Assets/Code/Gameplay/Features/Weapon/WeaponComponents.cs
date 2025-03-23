using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	[Game] public class Weapon : IComponent { }
	[Game] public class WeaponTypeIdComponent : IComponent { public WeaponTypeId Value; }

	[Game] public class ClosestTarget : IComponent { public GameEntity Value; }

	[Game] public class FirePositionTransform : IComponent { public Transform Value; }
	[Game] public class WeaponRotationPointTransform : IComponent { public Transform Value; }
	[Game] public class WeaponSpriteRenderer : IComponent { public SpriteRenderer Value; }
	[Game] public class WeaponRotationAngle : IComponent { public float Value; }

	[Game] public class ReloadTime : IComponent { public float Value; }
	[Game] public class MagazineSize : IComponent { public int Value; }

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