using Code.Gameplay.Features.Hero.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Hero
{
	[Game] public class Hero : IComponent {}
	[Game] public class HeroAnimatorComponent : IComponent { public HeroAnimator Value; }
	[Game] public class HeroTypeIdComponent : IComponent { public HeroTypeId Value; }

	[Game] public class Weaponed : IComponent { }
	[Game] public class Unweaponed : IComponent { }

	[Game] public class TheGeneral : IComponent { }
}