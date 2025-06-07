using Code.Meta.Features.Hud.AmmoHolder.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Ammo
{
	[Game] public class Ammo : IComponent { }

	[Game] public class AmmoTypeIdComponent : IComponent { public AmmoTypeId Value; }
	[Game] public class TargetLimit : IComponent { public int Value; }

	[Game] public class PistolBullet : IComponent { }
	[Game] public class RevolverBullet : IComponent { }
	[Game] public class ShotgunBullet : IComponent { }
	[Game] public class AutomaticPistolBullet : IComponent { }
	[Game] public class MachinegunBullet : IComponent { }
	[Game] public class SniperBullet : IComponent { }
	[Game] public class PlasmaBolt : IComponent { }
	[Game] public class LaserBolt : IComponent { }
	[Game] public class RocketMissile : IComponent { }

	[Game] public class AmmoHolder : IComponent { public AmmoHolderBehaviour Value; }
}