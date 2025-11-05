using System;

namespace Code.Gameplay.Features.Score.Services
{
	public interface IScoreService
	{
		event Action ScoreChanged;
		int GetCurrentScoreCount();
		void IncreaseScore(int value);
	}
}