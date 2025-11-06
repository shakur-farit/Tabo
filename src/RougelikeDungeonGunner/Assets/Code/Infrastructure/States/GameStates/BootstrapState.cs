using Code.Authentication;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Loading;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Leaderboard;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States.GameStates
{
	public class BootstrapState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IAssetProvider _assetProvider;
		private readonly ISceneLoader _sceneLoader;

		public BootstrapState(IGameStateMachine stateMachine, IAssetProvider assetProvider, ISceneLoader sceneLoader)
		{
			_stateMachine = stateMachine;
			_assetProvider = assetProvider;
			_sceneLoader = sceneLoader;
		}

		public override async void Enter()
		{
			LoadGameLoadingScene();
			await InitAddressables();
			EnterToInitializeLeaderboardState();
		}

		private void LoadGameLoadingScene() => 
			_sceneLoader.LoadSceneAdditive(Scenes.GameLoading);

		private async UniTask InitAddressables() => 
			await _assetProvider.Initialize();

		private void EnterToInitializeLeaderboardState() => 
			_stateMachine.Enter<InitializeLeaderboardState>();
	}
}