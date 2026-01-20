using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public class InitializeSpawnRequestSettingSystem : IInitializeSystem
  {
    private readonly ISpawnRequestSettingFactory _spawnRequestSettingFactory;

    public InitializeSpawnRequestSettingSystem(ISpawnRequestSettingFactory spawnRequestSettingFactory) => 
      _spawnRequestSettingFactory = spawnRequestSettingFactory;

    public void Initialize() => 
      _spawnRequestSettingFactory.CreateSpawnRequestSetting();
  }
}