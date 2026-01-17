using Code.Infrastructure.View;

namespace Code.Infrastructure.ObjectPool.Services
{
  public interface ISpawnActivationQueue
  {
    void Enqueue(EntityBehaviour view);
    void SetMaxActivationsPerFrame(int maxActivationsPerFrame);
  }
}