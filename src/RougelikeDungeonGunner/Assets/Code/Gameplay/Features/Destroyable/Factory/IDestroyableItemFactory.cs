using UnityEngine;

namespace Code.Gameplay.Features.Destroyable
{
  public interface IDestroyableItemFactory
  {
    GameEntity CreateDestroyableItem(DestroyableItemPlacingTypeId placingTypeId, Vector3 at);
  }
}