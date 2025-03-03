using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	[Game] public class FirePosition : IComponent { public Vector2 Value; }
	[Game] public class WeaponSprite : IComponent { public Sprite Value; }
}