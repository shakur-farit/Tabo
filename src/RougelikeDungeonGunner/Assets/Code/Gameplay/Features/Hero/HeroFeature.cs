using Assets.Code.Gameplay.Cameras.Systems;
using Assets.Code.Gameplay.Features.Hero.Systems;
using Assets.Code.Infrastructure.Systems;
using Assets.Code.Meta.Features.Hud.HeroHeartHolder.Systems;

namespace Assets.Code.Gameplay.Features.Hero
{
	public sealed class HeroFeature : Feature
	{
		public HeroFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SpawnHeroSystem>());

			Add(systems.Create<SetHeroCastStartLocalPositionSystem>());
			Add(systems.Create<SetHeroRuntimeAnimatorControllerSystem>());
			Add(systems.Create<SetHeroDirectionByInputSystem>());
			Add(systems.Create<SetCollisionInFrontFromWeaponSystem>());

			Add(systems.Create<CameraFollowHeroSystem>());

			Add(systems.Create<PushBackHeroOnCollisionSystem>());

			Add(systems.Create<AnimateHeroMovementSystem>());
			Add(systems.Create<CreateWeaponForHeroSystem>());
			Add(systems.Create<AnimateHeroAimingSystem>());

			Add(systems.Create<UpdateHeartUIForHeroInHolderSystem>());

			Add(systems.Create<HeroDeathSystem>());
			Add(systems.Create<FinalizeHeroDeathProcessingSystem>());
		}
	}
}