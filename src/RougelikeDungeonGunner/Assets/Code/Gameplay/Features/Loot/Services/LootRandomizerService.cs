using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Loot.Configs;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Loot.Services
{
	public class LootRandomizerService : ILootRandomizerService
	{
    private readonly IRandomService _random;
    private readonly IStaticDataService _staticDataService;

    public LootRandomizerService(IRandomService random, IStaticDataService staticDataService)
    {
      _random = random;
      _staticDataService = staticDataService;
    }

    public LootTypeId? GetRandomLoot(IEnumerable<LootTypeId> excludedLoot)
    {
      IEnumerable<LootConfig> lootConfigs = _staticDataService.GetAllLootConfigs();

      if (excludedLoot != null)
        lootConfigs = lootConfigs.Where(c => excludedLoot.Contains(c.TypeId) == false);

      List<LootConfig> configs = lootConfigs.ToList();
      if (configs.Count == 0)
        return null;

      float totalWeight = configs.Sum(c => c.DropChanceWeight);
      if (totalWeight <= 0f)
        return null;

      float roll = _random.Range(0f, totalWeight);
      float current = 0f;

      foreach (LootConfig config in configs)
      {
        current += config.DropChanceWeight;
        if (roll <= current)
          return config.TypeId;
      }

      return null;
    }
  }
}