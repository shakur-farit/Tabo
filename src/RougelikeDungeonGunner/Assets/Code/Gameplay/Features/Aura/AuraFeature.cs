using Assets.Code.Gameplay.Features.Aura.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Aura
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
			Add(systems.Create<SetAuraSpriteSystem>());
			Add(systems.Create<SetAuraMaterialSystem>());
			Add(systems.Create<SetAuraColorSystem>());
			Add(systems.Create<AuraDurationTickSystem>());

			Add(systems.Create<MarkDestroyDeadShieldSystem>());
			Add(systems.Create<MarkDestroyProcessedHealingAuraSystem>());
		}
	}
}