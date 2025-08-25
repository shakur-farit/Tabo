using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Ammo
{
	public sealed class AuraFeature : Feature
	{
		public AuraFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreateAuraForHeroSystem>());
			Add(systems.Create<CreateAuraForEnemySystem>());
			Add(systems.Create<SetAuraSizeSystem>());

			Add(systems.Create<MarkDestroyDeadShieldSystem>());
		}
	}
}