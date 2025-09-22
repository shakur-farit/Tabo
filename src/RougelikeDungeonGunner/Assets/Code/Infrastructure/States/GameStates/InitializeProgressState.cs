using Assets.Code.Infrastructure.States.StateInfrastructure;
using Assets.Code.Infrastructure.States.StateMachine;
using Assets.Code.Progress.Data.Progress;
using Assets.Code.Progress.Data.Transient;
using Assets.Code.Progress.Provider;

namespace Assets.Code.Infrastructure.States.GameStates
{
	public class InitializeProgressState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IProgressProvider _progressProvider;

		public InitializeProgressState(IGameStateMachine stateMachine, IProgressProvider progressProvider)
		{
			_stateMachine = stateMachine;
			_progressProvider = progressProvider;
		}

		public override void Enter()
		{
			InitializeProgress();
			_progressProvider.SetTransientData(new TransientData());
			EnterToLoadStaticDataState();
		}

		private void InitializeProgress() => 
			CreateNewProgress();

		private void CreateNewProgress() => 
			_progressProvider.SetProgressData(new ProgressData());

		private void EnterToLoadStaticDataState() => 
			_stateMachine.Enter<LoadStaticDataState>();
	}
}