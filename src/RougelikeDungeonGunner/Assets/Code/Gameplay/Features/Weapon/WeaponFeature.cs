using Code.Gameplay.Cameras.Systems;
using Code.Gameplay.Features.Weapon.Systems;
using Code.Infrastructure.Systems;
using Code.Meta.Features.Hud.AmmoHolder.Systems;
using Code.Meta.Features.Hud.WeaponHolder.Systems;

namespace Code.Gameplay.Features.Weapon
{
	public sealed class WeaponFeature : Feature
	{
		public WeaponFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ChangeCameraSizeByWeaponRangeSystem>());
			
			Add(systems.Create<UpdateWeaponIconInHolderSystem>());
			Add(systems.Create<UpdateWeaponNameInHolderSystem>());
			Add(systems.Create<UpdateAmmoUICountInHolderOnCreateOrReloadWeaponSystem>());
			Add(systems.Create<UpdateAmmoUICountInHolderForWeaponWithInfinityAmmoSystem>());
			Add(systems.Create<SetActiveTextOnInfinityAmmoSystem>());
			Add(systems.Create<SetInactiveTextOnLimitedAmmoSystem>());
			
			Add(systems.Create<FindClosestHeroTargetSystem>());
			Add(systems.Create<FindClosestEnemyTargetSystem>());
			Add(systems.Create<RotateHeroWeaponAlongClosestTargetSystem>());
			Add(systems.Create<RotateEnemyWeaponAlongHeroSystem>());
			Add(systems.Create<HeroWeaponDefaultRotateDirectionWithoutTargetSystem>());
			Add(systems.Create<SetWeaponDirectionSystem>());
			Add(systems.Create<PushBackHeroOnCollisionFrontWeaponSystem>());
			Add(systems.Create<CalculateMultiPelletCountSystem>());
			Add(systems.Create<SetHeroWeaponReloadingByPressButtonSystem>());
			Add(systems.Create<ReloadWeaponSystem>());
			
			Add(systems.Create<StartWeaponReloadingAnimationSystem>());
			Add(systems.Create<StartWeaponPrechargeAnimationSystem>());
			 
			Add(systems.Create<MarkWeaponReadyToShotSystem>());
			Add(systems.Create<SetHeroWeaponShootingByLeftMouseButtonInputSystem>());
			Add(systems.Create<PrechargeWeaponSystem>());
			
			Add(systems.Create<MarkDestructWeaponWithoutOwnerSystem>());

			Add(systems.Create<CleanupClosestHeroTargetSystem>());
		}
	}
}