using Code.Gameplay.Features.Ammo.Systems;
using Code.Gameplay.Features.Ammo.Systems.Visuals;
using Code.Gameplay.Features.Cooldowns.Systems;
using Code.Infrastructure.Systems;
using Code.Meta.Features.Hud.AmmoHolder.Systems;

namespace Code.Gameplay.Features.Ammo
{
	public sealed class AmmoFeature : Feature
	{
		public AmmoFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CooldownSystem>());

			Add(systems.Create<CreateAmmoForHeroPistolSystem>());
			Add(systems.Create<CreateAmmoForHeroAutomaticPistolSystem>());
			Add(systems.Create<CreateAmmoForHeroLaserBlasterSystem>());
			Add(systems.Create<CreateAmmoForHeroMachinegunSystem>());
			Add(systems.Create<CreateAmmoForHeroPlasmaGunSystem>());
			Add(systems.Create<CreateAmmoForHeroRevolverSystem>());
			Add(systems.Create<CreateAmmoForHeroShotgunSystem>());
			Add(systems.Create<CreateAmmoForHeroRocketLauncherSystem>());
			Add(systems.Create<CreateAmmoForHeroSniperSystem>());
			Add(systems.Create<CreateAmmoForEnemyPistolSystem>());

			Add(systems.Create<SetTargetLayerMaskSystem>());

			Add(systems.Create<ApplyTargetLimitToAmmoSystem>());
			Add(systems.Create<ApplyEffectsToAmmoSystem>());
			Add(systems.Create<ApplyStatusesToAmmoSystem>());

			Add(systems.Create<ApplyEnchantVisualsToAmmoReactiveSystem>());

			Add(systems.Create<CalculateCurrentAmmoCountSystem>());
			Add(systems.Create<UpdateAmmoUICountInHolderOnShotSystem>());

			Add(systems.Create<MarkAmmoProcessedOnWeaponFireRangeSystem>());
			Add(systems.Create<MarkAmmoProcessedOnTargetLimitExceededSystem>());
			Add(systems.Create<MarkAmmoProcessedOnCollideWithCollisionSystem>());
			Add(systems.Create<FinalizeProcessedAmmoSystem>());
		}
	}
}