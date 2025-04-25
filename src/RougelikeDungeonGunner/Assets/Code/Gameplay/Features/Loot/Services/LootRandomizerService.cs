using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Loot.Configs;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Loot
{
	public class LootRandomizerService : ILootRandomizerService
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IRandomService _random;

		public LootRandomizerService(IStaticDataService staticDataService, IRandomService random)
		{
			_staticDataService = staticDataService;
			_random = random;
		}

		public LootTypeId? GetLootToDrop(GameEntity enemy)
		{
			EnemyTypeId enemyType = enemy.EnemyTypeId;
			List<LootConfig> lootConfigs = _staticDataService.GetAllLootConfigs()
				.Where(config => config.EnemyTypeFilter.Count == 0 || config.EnemyTypeFilter.Contains(enemyType))
				.ToList();

			if (lootConfigs.Count == 0)
				return null;

			float totalWeight = lootConfigs.Sum(c => c.DropChanceWeight);

			if (totalWeight <= 0f)
				return null;

			float random = _random.Range(0f, totalWeight);
			float current = 0f;

			foreach (LootConfig config in lootConfigs)
			{
				current += config.DropChanceWeight;

				if (random <= current)
					return config.TypeId;
			}

			return null;
		}
	}
}