using Code.Infrastructure.Loading;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using UnityEngine;

namespace Code.Infrastructure.States.GameStates
{
	public class LoadingHomeScreenState : IState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ISceneLoader _sceneLoader;

		public LoadingHomeScreenState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
		{
			_stateMachine = stateMachine;
			_sceneLoader = sceneLoader;
		}

		public void Enter()
		{
			_sceneLoader.LoadScene(Scenes.HomeScreen, EnterHomeScreenState);
		}

		public void Exit()
		{

		}

		private void EnterHomeScreenState() => 
			_stateMachine.Enter<HomeScreenEnterState>();
	}
}