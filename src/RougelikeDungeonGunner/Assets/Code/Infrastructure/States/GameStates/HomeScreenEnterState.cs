using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.UIRoot.Factory;

namespace Code.Infrastructure.States.GameStates
{
	public class HomeScreenEnterState : SimpleState
	{
		private readonly IWindowService _windowService;
		private readonly IGameStateMachine _stateMachine;

		public HomeScreenEnterState(IWindowService windowService, IGameStateMachine stateMachine)
		{
			_windowService = windowService;
			_stateMachine = stateMachine;
		}


		public override void Enter()
		{
			OpenMainMenuWindow();
			EnterToHomeScreenState();
		}

		private void EnterToHomeScreenState() => 
			_stateMachine.Enter<HomeScreenState>();

		private void OpenMainMenuWindow() => 
			_windowService.Open(WindowId.MainMenuWindow);
	}
}