using Code.Gameplay.Features.Hero.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Hero
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