namespace Code.Gameplay.Features.Dungeon.Factory
{
	public interface IDungeonFactory
	{
		GameEntity CreateDungeon(DungeonTypeId typeId);
	}
}