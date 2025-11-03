using Code.Gameplay.Features.Level;
using Code.Gameplay.Features.Level.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Meta;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Data.Progress;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class LevelCompleteState : SimpleState
	{
		private readonly ILevelService _levelService;
		private readonly IWindowService _windowService;
    private readonly IHudDependPlatformProvider _hudProvider;
    private readonly ILeaderboardUpdater _leaderboardUpdater;
    private readonly ISaveSystem _save;

    public LevelCompleteState(
      ILevelService levelService, 
      IWindowService windowService, 
      IHudDependPlatformProvider hudProvider,
      ILeaderboardUpdater leaderboardUpdater,
      ISaveSystem save)
		{
			_levelService = levelService;
			_windowService = windowService;
      _hudProvider = hudProvider;
      _leaderboardUpdater = leaderboardUpdater;
      _save = save;
    }

		public override void Enter()
		{
			CloseHud();
			OpenLevelCompleteWindow();
			MarkNextLevel();
			SaveGame();
      _leaderboardUpdater.UpdateLeaderboard();
    }

		protected override void Exit() => 
			CloseLevelCompleteWindow();

		private void CloseHud() =>
      _windowService.Close(_hudProvider.GetHud());

    private void OpenLevelCompleteWindow() => 
			_windowService.Open(WindowId.LevelCompleteWindow);

		private void MarkNextLevel() =>
			_levelService.SetNextLevel();

    private void SaveGame() => 
      _save.Save();

    private void CloseLevelCompleteWindow() => 
			_windowService.Close(WindowId.LevelCompleteWindow);
	}
}