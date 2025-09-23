using Code.Gameplay.Features.Level.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Level
{
	public sealed class LevelFeature : Feature
	{
		public LevelFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CalculateTimeToSpawnEnemiesSystem>());
			Add(systems.Create<CalculateEnemiesInLevelSystem>());
			Add(systems.Create<AddEnemyWaveWithCooldownSystem>());
			Add(systems.Create<MarkLevelProcessedOnAllEnemiesDeadSystem>());
			Add(systems.Create<FinalizeProcessedLevelSystem>());
		}
	}
}