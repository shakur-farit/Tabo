using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Leaderboard;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States.GameStates
{
	public class InitializeLeaderboardState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILeaderboardInitializer _leaderboardInitializer;

		public InitializeLeaderboardState(IGameStateMachine stateMachine, ILeaderboardInitializer leaderboardInitializer)
		{
			_stateMachine = stateMachine;
			_leaderboardInitializer = leaderboardInitializer;
		}

		public override async void Enter()
		{
			await InitLeaderboard();
			EnterToInitializeAuthenticationState();
		}

		private async UniTask InitLeaderboard() => 
			await _leaderboardInitializer.Initialize();

		private void EnterToInitializeAuthenticationState() =>
			_stateMachine.Enter<InitializeAuthenticationState>();
	}
}
