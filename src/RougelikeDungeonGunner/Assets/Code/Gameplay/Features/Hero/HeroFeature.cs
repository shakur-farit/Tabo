using Code.Gameplay.Cameras.Systems;
using Code.Gameplay.Features.Hero.Systems;
using Code.Infrastructure;
using Code.Meta.UI.Hud.AmmoHolder.Registrars;
using Code.Meta.UI.Hud.HeartHolder.Systems;

namespace Code.Gameplay.Features.Hero
{
	public sealed class HeroFeature : Feature
	{
		public HeroFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SpawnHeroSystem>());

			Add(systems.Create<SetHeroDirectionByInputSystem>());
			Add(systems.Create<CameraFollowHeroSystem>());
			Add(systems.Create<AnimateHeroMovementSystem>());

			Add(systems.Create<HeroWeaponiseSystem>());
			Add(systems.Create<AnimateHeroAimingSystem>());

			Add(systems.Create<UpdateHeartUIForHeroInHolderSystem>());

			Add(systems.Create<HeroDeathSystem>());
			Add(systems.Create<FinalizeHeroDeathProcessingSystem>());
		}
	}
}