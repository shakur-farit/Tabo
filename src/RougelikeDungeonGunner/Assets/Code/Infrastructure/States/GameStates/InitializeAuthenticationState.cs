using Code.Authentication;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States.GameStates
{
	public class InitializeAuthenticationState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IPlayerAuthenticationService _authenticationService;

		public InitializeAuthenticationState(IGameStateMachine stateMachine, IPlayerAuthenticationService authenticationService)
		{
			_stateMachine = stateMachine;
			_authenticationService = authenticationService;
		}

		public override async void Enter()
		{
			await InitAuthentication();
			EnterToInitializeProgressState();
		}

		private async UniTask InitAuthentication()
		{
			await _authenticationService.Initialize();
			await _authenticationService.SignIn();
		}

		private void EnterToInitializeProgressState() =>
			_stateMachine.Enter<InitializeProgressState>();
	}
}