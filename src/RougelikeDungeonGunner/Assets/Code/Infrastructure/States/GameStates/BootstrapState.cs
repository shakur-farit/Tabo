using Code.Gameplay.StaticData;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;

namespace Code.Infrastructure.States.GameStates
{
	public class BootstrapState : IState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IStaticDataService _staticDataService;
		private readonly IAssetProvider _assetProvider;

		public BootstrapState(
			IGameStateMachine stateMachine, 
			IStaticDataService staticDataService,
			IAssetProvider assetProvider)
		{
			_stateMachine = stateMachine;
			_staticDataService = staticDataService;
			_assetProvider = assetProvider;
		}

		public async void Enter()
		{
			await _assetProvider.Initialize();

			await _staticDataService.Preload();

			_stateMachine.Enter<InitializeProgressState>();
		}

		public void Exit()
		{

		}
	}
}