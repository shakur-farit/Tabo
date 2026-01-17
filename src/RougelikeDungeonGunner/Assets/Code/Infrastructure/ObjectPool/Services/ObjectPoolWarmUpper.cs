using Code.Gameplay.StaticData;
using Code.Infrastructure.ObjectPool.Config;

namespace Code.Infrastructure.ObjectPool.Services
{
  public class ObjectPoolWarmUpper : IObjectPoolWarmUpper
  {
    private readonly IStaticDataService _staticDataService;
    private readonly IObjectPoolService _objectPool;
    private readonly ISpawnActivationQueue _spawnActivationQueue;

    public ObjectPoolWarmUpper(
      IStaticDataService staticDataService, 
      IObjectPoolService objectPool, 
      ISpawnActivationQueue spawnActivationQueue)
    {
      _staticDataService = staticDataService;
      _objectPool = objectPool;
      _spawnActivationQueue = spawnActivationQueue;
    }

    public void WarmupObjects()
    {
      ObjectPoolConfig config = _staticDataService.GetObjectPoolConfig();

      foreach (WarmupObject prefabToWarm in config.WarmupObjects)
        _objectPool.WarmUp(prefabToWarm.ViewPrefab, prefabToWarm.Count);

      _spawnActivationQueue.SetMaxActivationsPerFrame(config.MaxActivationsPerFrame);
  }
  }
}