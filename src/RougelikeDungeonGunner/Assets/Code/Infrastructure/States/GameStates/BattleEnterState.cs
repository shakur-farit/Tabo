using Code.Gameplay.Features.Levels.Factory;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleEnterState : IState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelFactory _levelFactory;
		private readonly IProgressProvider _progressProvider;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelFactory levelFactory,
			IProgressProvider progressProvider)
		{
			_stateMachine = stateMachine;
			_levelFactory = levelFactory;
			_progressProvider = progressProvider;
		}

		public void Enter()
		{
			_levelFactory.CreateLevel(_progressProvider.TransientData.CurrentLevel);

			_stateMachine.Enter<BattleLoopState>();
		}

		public void Exit()
		{

		}
	}
}