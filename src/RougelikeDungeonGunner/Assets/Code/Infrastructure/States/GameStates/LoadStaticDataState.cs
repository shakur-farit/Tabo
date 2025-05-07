using Code.Gameplay.StaticData;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using UnityEngine;

namespace Code.Infrastructure.States.GameStates
{
	public class LoadStaticDataState : IState
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGameStateMachine _stateMachine;

		public LoadStaticDataState(IStaticDataService staticDataService, IGameStateMachine stateMachine)
		{
			_staticDataService = staticDataService;
			_stateMachine = stateMachine;
		}

		public async void Enter()
		{
			await _staticDataService.Load();

			_stateMachine.Enter<LoadingHomeScreenState>();
		}

		public void Exit()
		{
			
		}
	}
}