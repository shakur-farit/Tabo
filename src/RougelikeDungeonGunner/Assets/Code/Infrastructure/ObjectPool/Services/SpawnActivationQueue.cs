using System.Collections.Generic;
using Code.Infrastructure.View;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.ObjectPool.Services
{
  public class SpawnActivationQueue : ITickable, ISpawnActivationQueue
  {
    private readonly Queue<EntityBehaviour> _activationQueue = new();
    private int _maxActivationsPerFrame;

    public void Enqueue(EntityBehaviour view) =>
      _activationQueue.Enqueue(view);

    public void Tick()
    {
      int count = Mathf.Min(_maxActivationsPerFrame, _activationQueue.Count);

      for (int i = 0; i < count; i++)
      {
        EntityBehaviour view = _activationQueue.Dequeue();
        view.gameObject.SetActive(true);
      }
    }

    public void SetMaxActivationsPerFrame(int maxActivationsPerFrame) => 
      _maxActivationsPerFrame = maxActivationsPerFrame;
  }
}