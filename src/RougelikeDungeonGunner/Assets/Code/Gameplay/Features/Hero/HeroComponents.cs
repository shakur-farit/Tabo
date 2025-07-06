using Code.Gameplay.Features.Hero.Behaviours;
using Code.Gameplay.Features.Weapon;
using Code.Meta.Features.Hud.HeartHolder.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Hero
{
	[Game] public class Hero : IComponent {}
	[Game] public class HeroAnimatorComponent : IComponent { public HeroAnimator Value; }
	[Game] public class HeroTypeIdComponent : IComponent { public HeroTypeId Value; }

	[Game] public class CurrentWeaponTypeId : IComponent { public WeaponTypeId Value; }
	[Game] public class Weaponed : IComponent { }
	[Game] public class Unweaponed : IComponent { }

	[Game] public class TheGeneral : IComponent { }
}