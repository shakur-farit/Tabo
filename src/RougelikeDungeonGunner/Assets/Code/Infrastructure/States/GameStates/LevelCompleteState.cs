using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class LevelCompleteState : IState
	{
		private readonly IProgressProvider _progressProvider;
		private readonly IGameStateMachine _stateMachine;

		public LevelCompleteState(IProgressProvider progressProvider, IGameStateMachine stateMachine)
		{
			_progressProvider = progressProvider;
			_stateMachine = stateMachine;
		}

		public void Enter()
		{
			_progressProvider.TransientData.CurrentLevel += 1;

			_stateMachine.Enter<BattleEnterState>();

		}

		public void Exit()
		{
			
		}
	}
}