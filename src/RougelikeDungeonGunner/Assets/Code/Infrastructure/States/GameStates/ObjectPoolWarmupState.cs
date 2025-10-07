using Code.Infrastructure.ObjectPool.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;

namespace Code.Infrastructure.States.GameStates
{
  public class ObjectPoolWarmupState : SimpleState
  {
    private readonly IObjectPoolWarmUpper _objectPoolWarmUpper;
    private readonly IGameStateMachine _stateMachine;

    public ObjectPoolWarmupState(IObjectPoolWarmUpper objectPoolWarmUpper, IGameStateMachine stateMachine)
    {
      _objectPoolWarmUpper = objectPoolWarmUpper;
      _stateMachine = stateMachine;
    }

    public override void Enter()
    { 
      _objectPoolWarmUpper.WarmupObjects();
      _stateMachine.Enter<LoadingHomeScreenState>();
    }
  }
}