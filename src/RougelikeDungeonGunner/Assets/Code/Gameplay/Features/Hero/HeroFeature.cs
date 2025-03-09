using Code.Gameplay.Cameras.Systems;
using Code.Gameplay.Features.Hero.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Hero
{
	public sealed class HeroFeature : Feature
	{
		public HeroFeature(ISystemsFactory systems)
		{
			Add(systems.Create<InitializeHeroWeaponSystem>());

			Add(systems.Create<SetHeroDirectionByInputSystem>());
			Add(systems.Create<CameraFollowHeroSystem>());
			Add(systems.Create<AnimateHeroMovementSystem>());
			Add(systems.Create<AnimateHeroAimingSystem>());
			Add(systems.Create<HeroDeathSystem>());
			Add(systems.Create<FinalizeHeroDeathProcessingSystem>());
		}
	}
}