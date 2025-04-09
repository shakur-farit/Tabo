using Code.Infrastructure;

namespace Code.Gameplay.Features.Levels
{
	public sealed class LevelFeature : Feature
	{
		public LevelFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CalculateEnemiesInLevelSystem>());
			Add(systems.Create<AddEnemyWaveWithCooldownSystem>());
			Add(systems.Create<MarkProcessedOnAllEnemiesDeadSystem>());
			Add(systems.Create<MarkHeroDestructedOnLevelProcessedSystem>());
			Add(systems.Create<FinalizeProcessedLevelSystem>());

			Add(systems.Create<CleanupEnvironmentSetupSystem>());
		}
	}
}