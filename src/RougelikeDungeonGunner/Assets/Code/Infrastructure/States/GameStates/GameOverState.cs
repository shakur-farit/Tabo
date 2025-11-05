using Code.Gameplay.Features.Level.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Leaderboard;
using Code.Meta;
using Code.Meta.Features.Hud.Services;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Services;
using Code.Progress.Data.Progress;

namespace Code.Infrastructure.States.GameStates
{
	public class GameOverState : SimpleState
	{
		private readonly IWindowService _windowService;
		private readonly ILevelService _levelService;
    private readonly IHudDependPlatformProvider _hudProvider;
    private readonly ILeaderboardUpdater _leaderboardUpdater;

    public GameOverState(
      IWindowService windowService, 
      ILevelService levelService, 
      IHudDependPlatformProvider hudProvider,
      ILeaderboardUpdater leaderboardUpdater)
		{
			_windowService = windowService;
			_levelService = levelService;

      _hudProvider = hudProvider;
      _leaderboardUpdater = leaderboardUpdater;
		}

		public override void Enter()
		{
			RemoveProgress();
			CloseHud();
			OpenGameOverWindow();
			UpdateLeaderboard();
    }

    private void CloseHud() =>
      _windowService.Close(_hudProvider.GetHud());

    private void OpenGameOverWindow() =>
			_windowService.Open(WindowId.GameOverWindow);

    private void RemoveProgress() =>
			_levelService.SetFirstLevel();

    private void UpdateLeaderboard() =>
	    _leaderboardUpdater.UpdateLeaderboard();
	}
}