using System.Collections.Generic;
using System.Linq;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Destroyable.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Factory
{
  public class DestroyableItemFactory : IDestroyableItemFactory
  {
    private readonly IIdentifierService _identifier;
    private readonly IStaticDataService _staticDataService;
    private readonly IRandomService _random;

    public DestroyableItemFactory(IIdentifierService identifier, IStaticDataService staticDataService, IRandomService random)
    {
      _identifier = identifier;
      _staticDataService = staticDataService;
      _random = random;
    }

    public GameEntity CreateDestroyableItem(DestroyableItemPlacingTypeId placingTypeId, Vector3 at)
    {
      List<DestroyableItemConfig> configs = _staticDataService.GetAllDestroyableItemConfigs()
        .Where(c => c.PlacingTypeId == placingTypeId)
        .ToList(); ;

      DestroyableItemConfig config = configs[_random.Range(0, configs.Count)];

      return CreateGameEntity.Empty()
          .AddId(_identifier.Next())
          .AddDestroyableItemTypeId(config.TypeId)
          .AddWorldPosition(at)
          .AddViewPrefab(config.ViewPrefab)
          .AddLootDropChance(config.LootDropChance)
          .AddExcludedLoot(config.ExcludedLoot)
          .AddSoundEffectTypeId(config.DestroyingSoundEffectTypeId)
          .With(x => x.isDestroyableItem = true)
        ;
    }
  }
}