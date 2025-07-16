namespace Code.Gameplay.Features.Levels
{
	public interface IDungeonFactory
	{
		GameEntity CreateDungeon(DungeonTypeId typeId);
	}
}