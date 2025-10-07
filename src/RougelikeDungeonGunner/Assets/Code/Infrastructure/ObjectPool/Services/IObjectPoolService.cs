using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Infrastructure.ObjectPool.Services
{
  public interface IObjectPoolService
  {
    void WarmUp(EntityBehaviour prefab, int count);
    EntityBehaviour Get(EntityBehaviour prefab, Vector3 at);
    void Return(EntityBehaviour prefab, EntityBehaviour instance);
  }
}