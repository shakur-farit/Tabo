using Code.Common.Entity;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable
{
  public class DestroyableItemFactory : IDestroyableItemFactory
  {
    private readonly IIdentifierService _identifier;
    private readonly IStaticDataService _staticDataService;

    public DestroyableItemFactory(IIdentifierService identifier, IStaticDataService staticDataService)
    {
      _identifier = identifier;
      _staticDataService = staticDataService;
    }

    public GameEntity CreateDestroyableItem(DestroyableItemTypeId typeId, Vector3 at)
    {
      return CreateEntity.Empty()
          .AddId(_identifier.Next())
          .AddWorldPosition(at)
        ;
    }
  }
}