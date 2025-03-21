using Code.Gameplay.Features.Hero.Behaviours;
using Code.Gameplay.Features.Weapon;
using Entitas;

namespace Code.Gameplay.Features.Hero
{
	[Game] public class Hero : IComponent {}
	[Game] public class HeroAnimatorComponent : IComponent { public HeroAnimator Value; }
	[Game] public class HeroTypeIdComponent : IComponent { public HeroTypeId Value; }

	[Game] public class TheGeneral : IComponent { }
}