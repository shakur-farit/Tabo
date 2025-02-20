using Code.Infrastructure.Loading;
using Code.Infrastructure.States.StateMachine;
using Code.Progress.Data;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.StateInfrastructure
{
	public class InitializeProgressState : IState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IProgressProvider _progressProvider;

		public InitializeProgressState(
			IGameStateMachine stateMachine,
			IProgressProvider progressProvider)
		{
			_stateMachine = stateMachine;
			_progressProvider = progressProvider;
		}

		public void Enter()
		{
			InitializeProgress();

			_stateMachine.Enter<LoadingBattleState, string>(Scenes.Gameplay);
		}

		private void InitializeProgress()
		{
			CreateNewProgress();
		}

		private void CreateNewProgress()
		{
			_progressProvider.SetProgressData(new ProgressData());
		}

		public void Exit()
		{
		}
	}
}