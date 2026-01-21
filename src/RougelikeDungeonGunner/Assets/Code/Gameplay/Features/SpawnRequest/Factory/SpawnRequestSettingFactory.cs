using System;
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

    public GameEntity CreateSpawnRequestSetting(SpawnRequestSettingTypeId typeId)
    {
	    switch (typeId)
	    {
				case SpawnRequestSettingTypeId.AmmoPattern:
					return CreateAmmoPatternSpawnRequestSetting(typeId);
				case SpawnRequestSettingTypeId.Enemy:
					return CreateEnemySpawnRequestSetting(typeId);
	    }

	    throw new Exception($"Spawn request setting for {typeId} type was not found");
		}

		private GameEntity CreateAmmoPatternSpawnRequestSetting(SpawnRequestSettingTypeId typeId) =>
	    CreateSpawnRequestSettingEntity(typeId)
		    .With(x => x.isAmmoPatternSpawnRequestSetting = true);

    private GameEntity CreateEnemySpawnRequestSetting(SpawnRequestSettingTypeId typeId) =>
	    CreateSpawnRequestSettingEntity(typeId)
		    .With(x => x.isEnemySpawnRequestSetting = true);


	private GameEntity CreateSpawnRequestSettingEntity(SpawnRequestSettingTypeId typeId)
    {
	    SpawnRequestSettingConfig config = _staticDataService.GetSpawnRequestSettingConfig(typeId);

			return CreateGameEntity.Empty()
		    .AddMaxSpawnPerFrame(config.MaxSpawnPerFrame)
		    .AddSpawnRequestSettingTypeId(typeId)
		    .With(x => x.isSpawnRequestSetting = true);
    }
  }
}