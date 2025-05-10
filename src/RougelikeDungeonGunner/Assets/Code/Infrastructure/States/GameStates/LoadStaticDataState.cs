using System.Threading.Tasks;
using Code.Gameplay.StaticData;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;

namespace Code.Infrastructure.States.GameStates
{
	public class LoadStaticDataState : SimpleState
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGameStateMachine _stateMachine;

		public LoadStaticDataState(IStaticDataService staticDataService, IGameStateMachine stateMachine)
		{
			_staticDataService = staticDataService;
			_stateMachine = stateMachine;
		}

		public override async void Enter()
		{
			await LoadStaticData();
			EnterToLoadingHomeScreenState();
		}

		private async Task LoadStaticData() => 
			await _staticDataService.Load();

		private void EnterToLoadingHomeScreenState() => 
			_stateMachine.Enter<LoadingHomeScreenState>();
	}
}