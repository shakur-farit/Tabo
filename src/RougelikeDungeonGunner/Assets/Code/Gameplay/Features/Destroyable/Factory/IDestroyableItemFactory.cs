using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Factory
{
  public interface IDestroyableItemFactory
  {
    GameEntity CreateDestroyableItem(DestroyableItemPlacingTypeId placingTypeId, Vector3 at);
  }
}