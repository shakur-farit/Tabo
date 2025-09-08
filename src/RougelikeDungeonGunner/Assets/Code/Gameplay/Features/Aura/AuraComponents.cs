using Code.Infrastructure.View.Registrars;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	[Game] public class Aura : IComponent { }
	[Game] public class AuraTypeIdComponent : IComponent { public AuraTypeId Value; }
	[Game] public class AuraLayer : IComponent { public int Value; }
	[Game] public class AuraRadius : IComponent { public float Value; }
	[Game] public class AuraLayerMask : IComponent { public LayerMask Value; }
	[Game] public class AuraDuration : IComponent { public float Value; }
	[Game] public class AuraDurationTimeLeft : IComponent { public float Value; }
	[Game] public class AuraPeriodTimeUp : IComponent { }
	[Game] public class AuraPeriod : IComponent { public float Value; }
	[Game] public class AuraPeriodTimeLeft : IComponent { public float Value; }

	[Game] public class RequestShield : IComponent { }
	[Game] public class RequestHealingAura : IComponent { }
	[Game] public class ShieldApplied : IComponent { }
	[Game] public class HealingAuraApplied : IComponent { }


	[Game] public class Shield : IComponent { }
	[Game] public class HealingAura : IComponent { }
	
}