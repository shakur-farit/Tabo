using Assets.Code.Infrastructure.States.StateInfrastructure;
using Assets.Code.Meta.UI.Windows;
using Assets.Code.Meta.UI.Windows.Service;
using Assets.Code.Progress.Provider;

namespace Assets.Code.Infrastructure.States.GameStates
{
	public class LevelCompleteState : SimpleState
	{
		private readonly IProgressProvider _progressProvider;
		private readonly IWindowService _windowService;

		public LevelCompleteState(IProgressProvider progressProvider, IWindowService windowService)
		{
			_progressProvider = progressProvider;
			_windowService = windowService;
		}

		public override void Enter()
		{
			CloseHud();
			OpenLevelCompleteWindow();
			MarkNextLevel();
		}

		protected override void Exit() => 
			CloseLevelCompleteWindow();

		private void CloseHud() => 
			_windowService.Close(WindowId.Hud);

		private void OpenLevelCompleteWindow() => 
			_windowService.Open(WindowId.LevelCompleteWindow);

		private void MarkNextLevel() => 
			_progressProvider.LevelData.CurrentLevel += 1;

		private void CloseLevelCompleteWindow() => 
			_windowService.Close(WindowId.LevelCompleteWindow);
	}
}