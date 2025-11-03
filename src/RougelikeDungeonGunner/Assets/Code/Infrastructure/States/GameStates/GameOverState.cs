using Code.Gameplay.Features.Level.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Data.Progress;

namespace Code.Infrastructure.States.GameStates
{
	public class GameOverState : SimpleState
	{
		private readonly IWindowService _windowService;
		private readonly ILevelService _levelService;
    private readonly ISaveSystem _save;
    private readonly IHudDependPlatformProvider _hudProvider;

    public GameOverState(
      IWindowService windowService, 
      ILevelService levelService, 
      ISaveSystem save, 
      IHudDependPlatformProvider hudProvider)
		{
			_windowService = windowService;
			_levelService = levelService;
      _save = save;
      _hudProvider = hudProvider;
    }

		public override void Enter()
		{
			RemoveProgress();
			CloseHud();
			OpenGameOverWindow();
			SaveGame();
		}

    private void CloseHud() =>
      _windowService.Close(_hudProvider.GetHud());

    private void OpenGameOverWindow() =>
			_windowService.Open(WindowId.GameOverWindow);

    private void RemoveProgress() =>
			_levelService.SetFirstLevel();

    private void SaveGame() => 
      _save.Save();
  }
}