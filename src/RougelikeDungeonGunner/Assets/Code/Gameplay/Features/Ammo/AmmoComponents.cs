using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Entitas;

namespace Code.Gameplay.Features.Ammo
{
	[Game] public class Ammo : IComponent { }

	[Game] public class AmmoIdComponent : IComponent { public AmmoId Value; }
	[Game] public class TargetLimit : IComponent { public int Value; }
	[Game] public class EffectSetups : IComponent { public List<EffectSetup> Value; }
	[Game] public class Processed : IComponent { }

	[Game] public class PistolBullet : IComponent { }
}