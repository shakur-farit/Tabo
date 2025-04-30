using Code.Gameplay.Cameras.Systems;
using Code.Gameplay.Features.Weapon.ChangeRequest;
using Code.Gameplay.Features.Weapon.Systems;
using Code.Infrastructure;
using Code.Meta.UI.Hud.AmmoHolder.Systems;
using Code.Meta.UI.Hud.WeaponHolder.Systems;

namespace Code.Gameplay.Features.Weapon
{
	public sealed class WeaponFeature : Feature
	{
		public WeaponFeature(ISystemsFactory systems)
		{
			Add(systems.Create<WeaponChangeRequestFeature>());
			Add(systems.Create<ChangeWeaponSystem>());
			Add(systems.Create<ChangeCameraSizeDependingOnWeaponTypeSystem>());

			Add(systems.Create<UpdateWeaponIconInHolderSystem>());
			Add(systems.Create<UpdateWeaponNameInHolderSystem>());
			Add(systems.Create<AmmoUICountInHolderSystem>());
			Add(systems.Create<SetActiveTextOnInfinityAmmoSystem>());
			Add(systems.Create<SetInactiveTextOnLimitedAmmoSystem>());
			
			Add(systems.Create<FindClosestTargetSystem>());
			Add(systems.Create<RotateWeaponAlongClosestTargetSystem>());
			Add(systems.Create<WeaponDefaultDirectionWithoutTargetSystem>());
			Add(systems.Create<CalculateMultiPelletCountSystem>());
			Add(systems.Create<SetReloadingByPressButtonSystem>());
			Add(systems.Create<ReloadWeaponSystem>());
			
			Add(systems.Create<StartWeaponReloadingAnimationSystem>());

			Add(systems.Create<MarkWeaponReadyToShotSystem>());
			Add(systems.Create<SetShootingByLeftMouseButtonInputSystem>());
			Add(systems.Create<PrechargeWeaponSystem>());

			Add(systems.Create<CleanupClosestTargetSystem>());
			Add(systems.Create<MarkDestructedUnparentedWeaponsSystem>());
		}
	}
}