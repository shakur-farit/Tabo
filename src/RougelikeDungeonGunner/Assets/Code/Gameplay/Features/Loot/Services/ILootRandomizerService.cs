using System.Collections.Generic;

namespace Code.Gameplay.Features.Loot.Services
{
	public interface ILootRandomizerService
	{
		LootTypeId? GetRandomLoot(IEnumerable<LootTypeId> excludedLoot);
	}
}