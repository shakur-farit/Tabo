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

		public GameOverState(IWindowService windowService, ILevelService levelService)
		{
			_windowService = windowService;
			_levelService = levelService;
		}

		public override void Enter()
		{
			RemoveProgress();
			CloseHud();
			OpenGameOverWindow();
		}

		private void CloseHud() => 
			_windowService.Close(WindowId.MobileHud);

		private void OpenGameOverWindow() =>
			_windowService.Open(WindowId.GameOverWindow);

		private void RemoveProgress() =>
			_levelService.SetFirstLevel();
	}
}