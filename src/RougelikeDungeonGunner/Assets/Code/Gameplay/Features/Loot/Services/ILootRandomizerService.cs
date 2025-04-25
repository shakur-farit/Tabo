namespace Code.Gameplay.Features.Loot
{
	public interface ILootRandomizerService
	{
		LootTypeId? GetLootToDrop(GameEntity enemy);
	}
}