using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect
{
	[Game] public class SpecialEffect : IComponent { }
	[Game] public class SpecialEffectTypeIdComponent : IComponent { public SpecialEffectTypeId Value; }
	[Game] public class SpecialEffectPositionOffset : IComponent { public Vector3 Value; }
	[Game] public class SpecialEffectApplied : IComponent { }
	[Game] public class FollowerSpecialEffect : IComponent { }
}