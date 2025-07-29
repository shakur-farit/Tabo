using Code.Gameplay.Cameras.Systems;
using Code.Gameplay.Features.Weapon.ChangeRequest;
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
			Add(systems.Create<WeaponChangeRequestFeature>());
			Add(systems.Create<ChangeWeaponSystem>());
			Add(systems.Create<ChangeCameraSizeByWeaponRangeSystem>());
			
			Add(systems.Create<UpdateWeaponIconInHolderSystem>());
			Add(systems.Create<UpdateWeaponNameInHolderSystem>());
			Add(systems.Create<UpdateAmmoUICountInHolderOnCreateOrReloadWeaponSystem>());
			Add(systems.Create<UpdateAmmoUICountInHolderForWeaponWithInfinityAmmoSystem>());
			Add(systems.Create<SetActiveTextOnInfinityAmmoSystem>());
			Add(systems.Create<SetInactiveTextOnLimitedAmmoSystem>());
			
			Add(systems.Create<FindClosestTargetSystem>());
			Add(systems.Create<RotateWeaponAlongClosestTargetSystem>());
			Add(systems.Create<WeaponDefaultRotateDirectionWithoutTargetSystem>());
			Add(systems.Create<SetWeaponDirectionSystem>());
			Add(systems.Create<PushBackHeroOnCollisionFrontWeaponSystem>());
			Add(systems.Create<CalculateMultiPelletCountSystem>());
			Add(systems.Create<SetReloadingByPressButtonSystem>());
			Add(systems.Create<ReloadWeaponSystem>());
			
			Add(systems.Create<StartWeaponReloadingAnimationSystem>());
			Add(systems.Create<StartWeaponPrechargeAnimationSystem>());
			 
			Add(systems.Create<MarkWeaponReadyToShotSystem>());
			Add(systems.Create<SetShootingByLeftMouseButtonInputSystem>());
			Add(systems.Create<PrechargeWeaponSystem>());

			Add(systems.Create<CleanupClosestTargetSystem>());
			Add(systems.Create<MarkDestructedUnparentedWeaponsSystem>());
		}
	}
}