using Code.Gameplay.StaticData;
using Code.Infrastructure.ObjectPool.Config;
using Cysharp.Threading.Tasks;

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

    public async UniTask WarmupObjects()
    {
      ObjectPoolConfig config = _staticDataService.GetObjectPoolConfig();
      int counter = 0;

      foreach (WarmupObject warmup in config.WarmupObjects)
      {
        for (int i = 0; i < warmup.Count; i++)
        {
          _objectPool.WarmUp(warmup.ViewPrefab, 1);
          counter++;

          if (counter >= config.WarmupObjectsPerFrameCount)
          {
            counter = 0;
            await UniTask.Yield(PlayerLoopTiming.Update);
          }
        }
      }
    }
  }
}