using Code.Infrastructure;

namespace Code.Gameplay.Features.Hero.Behaviours
{
	public sealed class HeroFeature : Feature
	{
		public HeroFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SetHeroDirectionByInputSystem>());
			Add(systems.Create<AnimateHeroMovementSystem>());
		}
	}
}