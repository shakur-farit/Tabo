using Code.Gameplay.Features.Level;
using Code.Gameplay.Features.Level.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class GameOverState : SimpleState
	{
		private readonly IWindowService _windowService;
		private readonly ILevelService _levelService;
    private readonly IHudDependPlatformProvider _hudProvider;

    public GameOverState(IWindowService windowService, ILevelService levelService, IHudDependPlatformProvider hudProvider)
		{
			_windowService = windowService;
			_levelService = levelService;
      _hudProvider = hudProvider;
    }

		public override void Enter()
		{
			RemoveProgress();
			CloseHud();
			OpenGameOverWindow();
		}

		private void CloseHud() =>
      _windowService.Close(_hudProvider.GetHud());

    private void OpenGameOverWindow() =>
			_windowService.Open(WindowId.GameOverWindow);

		private void RemoveProgress() =>
			_levelService.SetFirstLevel();
	}
}