using Code.Gameplay.StaticData;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States.GameStates
{
	public class GameLoadingUIState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IGameLoadingUIService _gameLoadingUIService;
		private readonly IStaticDataService _staticDataService;

		public GameLoadingUIState(
			IGameStateMachine stateMachine,
			IGameLoadingUIService gameLoadingUIService,
			IStaticDataService staticDataService)
		{
			_stateMachine = stateMachine;
			_gameLoadingUIService = gameLoadingUIService;
			_staticDataService = staticDataService;
		}

		public override async void Enter()
		{
			await PreLoad();
			OpenGameLoadingUI();
			EnterToInitializeLeaderboardState();
		}

		private async UniTask PreLoad() => 
			await _staticDataService.PreLoad();

		private void OpenGameLoadingUI() =>
			_gameLoadingUIService.Open();

		private void EnterToInitializeLeaderboardState() =>
			_stateMachine.Enter<InitializeLeaderboardState>();
	}
}