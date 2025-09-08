using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Ammo
{
	public sealed class AuraFeature : Feature
	{
		public AuraFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreateShieldForHeroSystem>());
			Add(systems.Create<CreateHealingAuraForHeroSystem>());
			Add(systems.Create<CreateShieldForEnemySystem>());
			Add(systems.Create<CreateHealingAuraForEnemySystem>());
			Add(systems.Create<SetAuraSizeSystem>());
			Add(systems.Create<AuraDurationTickSystem>());

			Add(systems.Create<MarkDestroyDeadShieldSystem>());
			Add(systems.Create<MarkDestroyProcessedHealingAuraSystem>());
		}
	}
}