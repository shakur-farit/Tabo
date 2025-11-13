using Code.Gameplay.Features.Level.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Leaderboard;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Services;

namespace Code.Infrastructure.States.GameStates
{
	public class LevelCompleteState : SimpleState
	{
		private readonly ILevelService _levelService;
		private readonly IWindowService _windowService;
    private readonly ILeaderboardUpdater _leaderboardUpdater;

    public LevelCompleteState(
      ILevelService levelService, 
      IWindowService windowService, 
      ILeaderboardUpdater leaderboardUpdater)
		{
			_levelService = levelService;
			_windowService = windowService;
      _leaderboardUpdater = leaderboardUpdater;
    }

		public override void Enter()
		{
			OpenLevelCompleteWindow();
			MarkNextLevel();
      UpdateLeaderboard();
    }

		protected override void Exit() => 
			CloseLevelCompleteWindow();

		private void OpenLevelCompleteWindow() => 
			_windowService.Open(WindowId.LevelCompleteWindow);

		private void MarkNextLevel() =>
			_levelService.SetNextLevel();

		private void CloseLevelCompleteWindow() => 
			_windowService.Close(WindowId.LevelCompleteWindow);

		private void UpdateLeaderboard() => 
			_leaderboardUpdater.UpdateLeaderboard();
	}
}