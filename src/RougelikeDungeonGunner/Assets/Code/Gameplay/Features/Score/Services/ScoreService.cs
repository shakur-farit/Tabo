using System;

namespace Code.Gameplay.Features.Hero.Services
{
	public class ScoreService : IScoreService
	{
		public event Action ScoreChanged;

		private int _currentScoreCount;

		public int GetCurrentScoreCount() =>
			_currentScoreCount;

		public void IncreaseScore(int value)
		{
			_currentScoreCount += value;

			ScoreChanged?.Invoke();
		}
	}
}