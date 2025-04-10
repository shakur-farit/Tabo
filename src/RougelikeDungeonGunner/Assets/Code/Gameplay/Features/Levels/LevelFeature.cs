using Code.Infrastructure;

namespace Code.Gameplay.Features.Levels
{
	public sealed class LevelFeature : Feature
	{
		public LevelFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CalculateEnemiesInLevelSystem>());
			Add(systems.Create<AddEnemyWaveWithCooldownSystem>());
			Add(systems.Create<MarkLevelProcessedOnAllEnemiesDeadSystem>());
			//Add(systems.Create<MarkHeroDestructedOnLevelProcessedSystem>());
			//Add(systems.Create<MarkWeaponDestructedOnLevelProcessedSystem>());
			Add(systems.Create<MarkHeroDestructedSystem>());
			Add(systems.Create<MarkWeaponDestructedSystem>());
			Add(systems.Create<FinalizeProcessedLevelSystem>());

			Add(systems.Create<CleanupEnvironmentSetupSystem>());
		}
	}
}