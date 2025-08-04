using System.Collections.Generic;
using Code.Gameplay.Features.TargetCollection;
using Code.Gameplay.Features.Weapon.Configs;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	[Game] public class AmmoPattern : IComponent { }
	[Game] public class AmmoPatternSetupComponent : IComponent { public AmmoPatternSetup Value; }
	[Game] public class AmmoTransformsList : IComponent { public List<Transform> Value; }
	[Game] public class RotateRadius : IComponent { public float Value; }
	[Game] public class RotateSpeed : IComponent { public float Value; }
	[Game] public class PatternAmmoCount : IComponent { public int Value; }
	[Game] public class PatternCenter : IComponent { public Vector3 Value; }

	[Game] public class SinglePattern : IComponent { }
	[Game] public class CirclePattern : IComponent { }
	[Game] public class TrianglePattern : IComponent { }
	[Game] public class StarPattern : IComponent { }
}