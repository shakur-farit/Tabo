using Code.Infrastructure.View;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.ObjectPool.Services
{
  public class ObjectPoolService : IObjectPoolService
  {
    private readonly Dictionary<EntityBehaviour, Queue<EntityBehaviour>> _pools = new();
    private readonly IInstantiator _instantiator;
    private readonly ISpawnActivationQueue _spawnActivationQueue;
    private readonly Transform _rootContainer;

    public ObjectPoolService(IInstantiator instantiator, ISpawnActivationQueue spawnActivationQueue)
    {
      _instantiator = instantiator;
      _spawnActivationQueue = spawnActivationQueue;

      GameObject rootGameObject = new GameObject("ObjectPool");
      Object.DontDestroyOnLoad(rootGameObject);
      _rootContainer = rootGameObject.transform;
    }

    public void WarmUp(EntityBehaviour prefab, int count)
    {
      if (_pools.ContainsKey(prefab) == false)
        _pools[prefab] = new Queue<EntityBehaviour>();

      for (int i = 0; i < count; i++)
      {
        EntityBehaviour instance = CreateInstance(prefab, Vector3.zero);
        Return(prefab, instance);
      }
    }

    public EntityBehaviour Get(EntityBehaviour prefab, Vector3 at)
    {
      EntityBehaviour instance;

      if (_pools.TryGetValue(prefab, out Queue<EntityBehaviour> queue) && queue.Count > 0)
        instance = queue.Dequeue();
      else
        instance = CreateInstance(prefab, at);

      instance.transform.position = at;
      instance.gameObject.SetActive(true);

      //_spawnActivationQueue.Enqueue(instance);

      return instance;
    }

    public void Return(EntityBehaviour prefab, EntityBehaviour instance)
    {
      if (_pools.ContainsKey(prefab) == false)
        _pools[prefab] = new Queue<EntityBehaviour>();

      instance.gameObject.SetActive(false);
      instance.transform.SetParent(_rootContainer);
      _pools[prefab].Enqueue(instance);
    }

    private EntityBehaviour CreateInstance(EntityBehaviour prefab, Vector3 at)
    {
      EntityBehaviour instance = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
        prefab,
        position: at,
        rotation: Quaternion.identity,
        parentTransform: _rootContainer);

      return instance;
    }
  }
}