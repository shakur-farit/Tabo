using Code.Gameplay.Features.Levels.Factory;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
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
			_levelFactory.CreateLevel(_progressProvider.TransientData.CurrentLevel);

		private void OpenHud() => 
			_windowService.Open(WindowId.Hud);

		private void EnterToBattleLoop() => 
			_stateMachine.Enter<BattleLoopState>();
	}
}