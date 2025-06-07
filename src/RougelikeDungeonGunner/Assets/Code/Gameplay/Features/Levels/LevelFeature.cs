using Code.Gameplay.Features.Hero.Systems;
using Code.Gameplay.Features.Levels.Systems;
using Code.Gameplay.Features.Weapon.Systems;
using Code.Infrastructure;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Levels
{
	public sealed class LevelFeature : Feature
	{
		public LevelFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CalculateEnemiesInLevelSystem>());
			Add(systems.Create<AddEnemyWaveWithCooldownSystem>());
			Add(systems.Create<MarkLevelProcessedOnAllEnemiesDeadSystem>());
			Add(systems.Create<FinalizeProcessedLevelSystem>());

			Add(systems.Create<CleanupEnvironmentSetupSystem>());
		}
	}
}