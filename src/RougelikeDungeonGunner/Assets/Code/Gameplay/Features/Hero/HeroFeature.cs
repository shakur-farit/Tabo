using Code.Gameplay.Cameras.Systems;
using Code.Gameplay.Features.Hero.Systems;
using Code.Infrastructure.Systems;
using Code.Meta.Features.Hud.HeroHeartHolder.Systems;

namespace Code.Gameplay.Features.Hero
{
	public sealed class HeroFeature : Feature
	{
		public HeroFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SpawnHeroSystem>());

			Add(systems.Create<SetHeroDirectionByInputSystem>());
			Add(systems.Create<SetCollisionInFrontFromWeaponSystem>());
			Add(systems.Create<CameraFollowHeroSystem>());

			Add(systems.Create<AnimateHeroMovementSystem>());
			Add(systems.Create<CreateWeaponForHeroSystem>());
			Add(systems.Create<AnimateHeroAimingSystem>());

			Add(systems.Create<UpdateHeartUIForHeroInHolderSystem>());

			Add(systems.Create<HeroDeathSystem>());
			Add(systems.Create<FinalizeHeroDeathProcessingSystem>());
		}
	}
}