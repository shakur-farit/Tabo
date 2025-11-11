using Code.Infrastructure.Loading;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.GameLoading.Services;
using Code.Meta.UI.Windows;

namespace Code.Infrastructure.States.GameStates
{
	public class LoadingBattleState : SimplePayloadState<string>
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ISceneLoader _sceneLoader;
		private readonly IGameLoadingUIService _gameLoadingUIService;

		public LoadingBattleState(
			IGameStateMachine stateMachine, 
			ISceneLoader sceneLoader, 
			IGameLoadingUIService gameLoadingUIService)
		{
			_stateMachine = stateMachine;
			_sceneLoader = sceneLoader;
			_gameLoadingUIService = gameLoadingUIService;
		}

		public override void Enter(string sceneName)
		{
			OpenGameLoadingUI();
			LoadGameplayScene(sceneName);
		}

		private void OpenGameLoadingUI() => 
			_gameLoadingUIService.Open();

		private void LoadGameplayScene(string sceneName) => 
			_sceneLoader.LoadScene(sceneName, EnterBattleLoopState);

		private void EnterBattleLoopState() => 
			_stateMachine.Enter<BattleEnterState>();
	}
}