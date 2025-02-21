using Entitas;

namespace Code.Gameplay.Features.Hero.Behaviours
{
	[Game] public class Hero : IComponent {}
	[Game] public class HeroAnimatorComponent : IComponent { public HeroAnimator Value; }
}