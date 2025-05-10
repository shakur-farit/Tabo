using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.UIRoot.Factory;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class LevelCompleteState : IState
	{
		private readonly IProgressProvider _progressProvider;
		private readonly IGameStateMachine _stateMachine;
		private readonly IWindowService _windowService;

		public LevelCompleteState(
			IProgressProvider progressProvider, 
			IGameStateMachine stateMachine,
			IWindowService windowService)
		{
			_progressProvider = progressProvider;
			_stateMachine = stateMachine;
			_windowService = windowService;
		}

		public void Enter()
		{
			_windowService.Close(WindowId.Hud);
			_windowService.Open(WindowId.LevelCompleteWindow);

			_progressProvider.TransientData.CurrentLevel += 1;
		}

		public void Exit()
		{
			_windowService.Close(WindowId.LevelCompleteWindow);
		}
	}
}