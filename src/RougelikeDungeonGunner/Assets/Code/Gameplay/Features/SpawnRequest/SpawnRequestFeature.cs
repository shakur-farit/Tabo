using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public sealed class SpawnRequestFeature : Feature
  {
    public SpawnRequestFeature(ISystemsFactory systems)
    {
      Add(systems.Create<InitializeSpawnRequestSettingSystem>());

      Add(systems.Create<ProcessAmmoPatternSpawnRequestSystem>());
      Add(systems.Create<ProcessEnemySpawnRequestSystem>());

      Add(systems.Create<MarkDestructedProcessedSpawnRequestsSystem>());
    }
  }
}