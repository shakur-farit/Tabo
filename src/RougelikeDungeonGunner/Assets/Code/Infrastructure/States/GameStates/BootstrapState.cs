using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States.GameStates
{
	public class BootstrapState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IAssetProvider _assetProvider;
    private readonly ILeaderboardInitializer _leaderboardInitializer;

    public BootstrapState(IGameStateMachine stateMachine, IAssetProvider assetProvider, ILeaderboardInitializer leaderboardInitializer)
		{
			_stateMachine = stateMachine;
			_assetProvider = assetProvider;
      _leaderboardInitializer = leaderboardInitializer;
    }

		public override async void Enter()
		{
			await InitAddressables();
      await _leaderboardInitializer.Initialize();
			EnterToInitializeProgressState();
		}

		private async UniTask InitAddressables() => 
			await _assetProvider.Initialize();

		private void EnterToInitializeProgressState() => 
			_stateMachine.Enter<InitializeProgressState>();
	}
}