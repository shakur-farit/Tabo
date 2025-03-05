using Code.Gameplay.Features.Ammo;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	[Game] public class WeaponIdComponent : IComponent { public WeaponId Value; }
	[Game] public class FirePositionTransform : IComponent { public Transform Value; }
	[Game] public class WeaponSpriteRenderer : IComponent { public SpriteRenderer Value; }
	[Game] public class FireRange : IComponent { public float Value; }
	[Game] public class ReloadTime : IComponent { public float Value; }
	[Game] public class MagazineSize : IComponent { public int Value; }
	[Game] public class Weapon : IComponent { }
	[Game] public class Pistol : IComponent { }
}