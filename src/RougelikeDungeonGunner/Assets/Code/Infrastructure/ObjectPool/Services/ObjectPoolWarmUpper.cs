using Code.Gameplay.StaticData;
using Code.Infrastructure.ObjectPool.Config;

namespace Code.Infrastructure.ObjectPool.Services
{
  public class ObjectPoolWarmUpper : IObjectPoolWarmUpper
  {
    private readonly IStaticDataService _staticDataService;
    private readonly IObjectPoolService _objectPool;

    public ObjectPoolWarmUpper(IStaticDataService staticDataService, IObjectPoolService objectPool)
    {
      _staticDataService = staticDataService;
      _objectPool = objectPool;
   
    }

    public void WarmupObjects()
    {
      ObjectPoolConfig config = _staticDataService.GetObjectPoolConfig();

      foreach (WarmupObject prefabToWarm in config.WarmupObjects)
        _objectPool.WarmUp(prefabToWarm.ViewPrefab, prefabToWarm.Count);
    }
  }
}