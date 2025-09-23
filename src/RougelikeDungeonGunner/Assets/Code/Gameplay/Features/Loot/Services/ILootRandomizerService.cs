namespace Code.Gameplay.Features.Loot.Services
{
	public interface ILootRandomizerService
	{
		LootTypeId? GetLootToDrop(GameEntity enemy);
	}
}