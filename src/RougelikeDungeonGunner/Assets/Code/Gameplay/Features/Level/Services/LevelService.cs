namespace Code.Gameplay.Features.Level.Services
{
	public class LevelService : ILevelService
	{
		private int _currentLevel = 1;

		public int GetCurrentLevel() => 
			_currentLevel;

		public void SetNextLevel() => 
			_currentLevel += 1;

		public void SetFirstLevel() => 
			_currentLevel = 1;
	}
}