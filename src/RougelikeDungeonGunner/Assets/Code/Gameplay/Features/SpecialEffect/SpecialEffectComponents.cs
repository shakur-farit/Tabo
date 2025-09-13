using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Loot
{
	[Game] public class SpecialEffect : IComponent { }
	[Game] public class SpecialEffectTypeIdComponent : IComponent { public SpecialEffectTypeId Value; }
	[Game] public class ParticleSystemComponent : IComponent { public ParticleSystem Value; }
	
	[Game] public class Smoke : IComponent { }
}