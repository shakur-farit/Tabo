using System;

namespace Code.Gameplay.Features.Hero.Services
{
	public interface IScoreService
	{
		event Action ScoreChanged;
		int GetCurrentScoreCount();
		void IncreaseScore(int value);
	}
}