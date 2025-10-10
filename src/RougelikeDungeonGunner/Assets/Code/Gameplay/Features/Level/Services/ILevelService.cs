namespace Code.Gameplay.Features.Level.Services
{
	public interface ILevelService
	{
		int GetCurrentLevel();
		void SetNextLevel();
		void SetFirstLevel();
	}
}