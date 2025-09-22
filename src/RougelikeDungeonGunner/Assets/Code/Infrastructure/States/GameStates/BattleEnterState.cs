using Assets.Code.Gameplay.Features.Level.Factory;
using Assets.Code.Infrastructure.States.StateInfrastructure;
using Assets.Code.Infrastructure.States.StateMachine;
using Assets.Code.Meta.UI.Windows;
using Assets.Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;

namespace Assets.Code.Infrastructure.States.GameStates
{
	public class BattleEnterState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelFactory _levelFactory;
		private readonly IProgressProvider _progressProvider;
		private readonly IWindowService _windowService;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelFactory levelFactory,
			IProgressProvider progressProvider,
			IWindowService windowService)
		{
			_stateMachine = stateMachine;
			_levelFactory = levelFactory;
			_progressProvider = progressProvider;
			_windowService = windowService;
		}

		public override void Enter()
		{
			CreateNewLevel();
			OpenHud();
			EnterToBattleLoop();
		}

		private void CreateNewLevel() => 
			_levelFactory.CreateLevel(_progressProvider.LevelData.CurrentLevel);

		private void OpenHud() => 
			_windowService.Open(WindowId.Hud);

		private void EnterToBattleLoop() => 
			_stateMachine.Enter<BattleLoopState>();
	}
}