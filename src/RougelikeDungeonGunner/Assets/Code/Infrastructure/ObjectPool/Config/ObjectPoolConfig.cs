using System;
using System.Collections.Generic;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Infrastructure.ObjectPool.Config
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Object Pool Config", fileName = "ObjectPoolConfig")]
  public class ObjectPoolConfig : ScriptableObject
  {
    public int WarmupObjectsPerFrameCount;
    public List<WarmupObject> WarmupObjects;
  }

  [Serializable]
  public class WarmupObject
  {
    public EntityBehaviour ViewPrefab;
    public int Count;
  }
}