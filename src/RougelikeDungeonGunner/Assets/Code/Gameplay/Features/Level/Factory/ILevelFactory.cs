namespace Code.Gameplay.Features.Levels.Factory
{
	public interface ILevelFactory
	{
		GameEntity CreateLevel(int level);
	}
}