namespace Code.Gameplay.Features.Level
{
	public interface ILevelService
	{
		int GetCurrentLevel();
		void SetNextLevel();
		void SetFirstLevel();
	}
}