namespace Code.Gameplay.Features.Levels
{
	public interface ILevelFactory
	{
		GameEntity CreateLevel(int level);
	}
}