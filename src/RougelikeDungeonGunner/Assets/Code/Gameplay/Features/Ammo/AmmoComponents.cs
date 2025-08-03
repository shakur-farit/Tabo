using Code.Gameplay.Features.Weapon.Configs;
using Entitas;

namespace Code.Gameplay.Features.Ammo
{
	[Game] public class Ammo : IComponent { }
	[Game] public class AmmoTypeIdComponent : IComponent { public AmmoTypeId Value; }
	[Game] public class TargetLimit : IComponent { public int Value; }

	[Game] public class LightBullet : IComponent { }
	[Game] public class RifleBullet : IComponent { }
	[Game] public class ShotgunShell : IComponent { }
	[Game] public class LongRangeBullet : IComponent { }
	[Game] public class LaserBolt : IComponent { }
	[Game] public class RocketMissile : IComponent { }

	[Game] public class AmmoPatternComponent : IComponent { public AmmoPattern Value; }
}