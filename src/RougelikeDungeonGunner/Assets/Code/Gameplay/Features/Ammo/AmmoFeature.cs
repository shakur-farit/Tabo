using Code.Gameplay.Features.Ammo.Systems;
using Code.Gameplay.Features.Cooldowns.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Ammo
{
	public sealed class AmmoFeature : Feature
	{
		public AmmoFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CooldownSystem>());

			Add(systems.Create<CreatingOfPistolBulletSystem>());
			Add(systems.Create<CreatingOfAutomaticPistolBulletSystem>());
			Add(systems.Create<CreatingOfLaserBoltSystem>());
			Add(systems.Create<CreatingOfMachinegunBulletSystem>());
			Add(systems.Create<CreatingOfPlasmaBoltSystem>());
			Add(systems.Create<CreatingOfRevolverBulletSystem>());
			Add(systems.Create<CreatingOfShotgunBulletSystem>());
			Add(systems.Create<CreatingOfRocketMissileSystem>());
			Add(systems.Create<CreatingOfSniperBulletSystem>());

			Add(systems.Create<ApplyEffectsToAmmoSystem>());
			Add(systems.Create<ApplyStatusesToAmmoSystem>());

			Add(systems.Create<ApplyEnchantVisualsToAmmoReactiveSystem>());

			Add(systems.Create<CalculateCurrentAmmoAmountSystem>());

			Add(systems.Create<MarkAmmoProcessedOnWeaponFireRangeSystem>());
			Add(systems.Create<MarkAmmoProcessedOnTargetLimitExceededSystem>());
			Add(systems.Create<FinalizeProcessedAmmoSystem>());
		}
	}
}