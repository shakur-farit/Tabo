using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Progress.Data.Progress;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class InitializeProgressState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IProgressProvider _progressProvider;
    private readonly ILoadSystem _load;

    public InitializeProgressState(IGameStateMachine stateMachine, IProgressProvider progressProvider, ILoadSystem load)
		{
			_stateMachine = stateMachine;
			_progressProvider = progressProvider;
      _load = load;
    }

		public override void Enter()
		{
			InitializeProgress();
			EnterToLoadStaticDataState();
		}

		private void InitializeProgress() => 
			LoadOrCreateNewProgress();

    private void LoadOrCreateNewProgress() => 
      _progressProvider.SetProgressData(_load.Load() ?? new ProgressData());

    private void EnterToLoadStaticDataState() => 
			_stateMachine.Enter<LoadStaticDataState>();
	}
}