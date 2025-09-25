using UnityEngine;

namespace Code.Gameplay.Features.Destroyable
{
  public interface IDestroyableItemFactory
  {
    GameEntity CreateDestroyableItem(DestroyableItemTypeId typeId, Vector3 at);
  }
}