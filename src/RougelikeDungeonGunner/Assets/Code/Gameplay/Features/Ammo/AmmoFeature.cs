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
			Add(systems.Create<PistolBulletSystem>());
			Add(systems.Create<AmmoLifeRangeSystem>());
			Add(systems.Create<MarkProcessedOnTargetLimitExceededSystem>());
			Add(systems.Create<FinalizeProcessedAmmoSystem>());
		}
	}
}