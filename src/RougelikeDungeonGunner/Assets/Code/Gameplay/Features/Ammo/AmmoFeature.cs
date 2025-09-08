using Code.Gameplay.Features.Ammo.Systems;
using Code.Gameplay.Features.Ammo.Systems.Visuals;
using Code.Gameplay.Features.AmmoPattern.Systems;
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

			Add(systems.Create<CreateAmmoFromSinglePatternSystem>());
			Add(systems.Create<CreateAmmoFromCirclePatternSystem>());
			Add(systems.Create<CreateAmmoFromTrianglePatternSystem>());
			Add(systems.Create<CreateAmmoFromStarPatternSystem>());

			Add(systems.Create<AddAmmoTransformInListSystem>());

			Add(systems.Create<SetAmmoOrbitCenterSystem>());
			Add(systems.Create<SetTargetLayerMaskSystem>());

			Add(systems.Create<AmmoRotateSystem>());

			Add(systems.Create<ApplyTargetLimitToAmmoSystem>());
			Add(systems.Create<ApplyEffectsToAmmoSystem>());
			Add(systems.Create<ApplyStatusesToAmmoSystem>());

			Add(systems.Create<ApplyEnchantVisualsToAmmoReactiveSystem>());

			Add(systems.Create<CalculateCurrentAmmoCountSystem>());
			Add(systems.Create<UpdateAmmoUICountInHolderOnShotSystem>());

			Add(systems.Create<MarkAmmoProcessedOnWeaponFireRangeSystem>());
			Add(systems.Create<MarkAmmoProcessedOnTargetLimitExceededSystem>());
			Add(systems.Create<MarkAmmoProcessedOnCollideWithCollisionSystem>());

			Add(systems.Create<RemoveProcessedAmmoFromPatternListSystem>());

			Add(systems.Create<FinalizeProcessedAmmoSystem>());
		}
	}
}