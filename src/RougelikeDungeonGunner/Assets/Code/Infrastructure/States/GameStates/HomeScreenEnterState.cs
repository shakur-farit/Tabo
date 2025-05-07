using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.UIRoot.Factory;
using UnityEngine;

namespace Code.Infrastructure.States.GameStates
{
	public class HomeScreenEnterState : IState
	{
		private readonly IWindowService _windowService;
		private IGameStateMachine _stateMachine;

		public HomeScreenEnterState(
			IWindowService windowService, 
			IGameStateMachine stateMachine)
		{
			_windowService = windowService;
			_stateMachine = stateMachine;
		}


		public void Enter()
		{
			_windowService.Open(WindowId.MainMenuWindow);

			_stateMachine.Enter<HomeScreenState>();
		}

		public void Exit()
		{

		}
	}
}