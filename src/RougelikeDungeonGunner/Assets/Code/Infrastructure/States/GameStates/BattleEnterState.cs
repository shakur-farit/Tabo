using Code.Gameplay.Levels;
using Code.Infrastructure.States.StateMachine;

namespace Code.Infrastructure.States.StateInfrastructure
{
	public class BattleEnterState : IState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelDataProvider _levelDataProvider;
		private readonly GameContext _gameContext;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelDataProvider levelDataProvider)
		{
			_stateMachine = stateMachine;
			_levelDataProvider = levelDataProvider;
		}

		public void Enter()
		{
			PlaceHero();

			_stateMachine.Enter<BattleLoopState>();
		}

		private void PlaceHero()
		{
		}

		public void Exit()
		{

		}
	}
}