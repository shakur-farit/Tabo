using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public class SpawnRequestSettingFactory : ISpawnRequestSettingFactory
  {
    private readonly IStaticDataService _staticDataService;

    public SpawnRequestSettingFactory(IStaticDataService staticDataService) => 
      _staticDataService = staticDataService;

    public GameEntity CreateSpawnRequestSetting()
    {
      SpawnRequestSettingConfig config = _staticDataService.GetSpawnRequestSettingConfig();

      return CreateGameEntity.Empty()
        .AddMaxSpawnPerFrame(config.MaxSpawnPerFrame)
        .With(x => x.isSpawnRequestSetting = true);

    }
  }
}