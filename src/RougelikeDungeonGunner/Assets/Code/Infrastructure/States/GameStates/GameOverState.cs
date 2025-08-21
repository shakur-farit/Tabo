using Code.Infrastructure.States.StateInfrastructure;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class GameOverState : SimpleState
	{
		private readonly IWindowService _windowService;
		private readonly IProgressProvider _progressProvider;

		public GameOverState(IWindowService windowService, IProgressProvider progressProvider)
		{
			_windowService = windowService;
			_progressProvider = progressProvider;
		}

		public override void Enter()
		{
			RemoveProgress();
			CloseHud();
			OpenGameOverWindow();
		}

		private void CloseHud() => 
			_windowService.Close(WindowId.Hud);

		private void OpenGameOverWindow() =>
			_windowService.Open(WindowId.GameOverWindow);

		private void RemoveProgress() => 
			_progressProvider.LevelData.CurrentLevel = 1;
	}
}