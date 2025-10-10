using Code.Gameplay.Features.Level;
using Code.Gameplay.Features.Level.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class LevelCompleteState : SimpleState
	{
		private readonly ILevelService _levelService;
		private readonly IWindowService _windowService;

		public LevelCompleteState(ILevelService levelService, IWindowService windowService)
		{
			_levelService = levelService;
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
			_levelService.SetNextLevel();

		private void CloseLevelCompleteWindow() => 
			_windowService.Close(WindowId.LevelCompleteWindow);
	}
}