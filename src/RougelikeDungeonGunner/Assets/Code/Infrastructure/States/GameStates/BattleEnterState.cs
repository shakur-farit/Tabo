using Code.Gameplay.Features.Hero.Behaviours;
using Code.Gameplay.Levels;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleEnterState : IState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelDataProvider _levelDataProvider;
		private readonly IHeroFactory _heroFactory;
		private readonly GameContext _gameContext;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelDataProvider levelDataProvider,
			IHeroFactory heroFactory)
		{
			_stateMachine = stateMachine;
			_levelDataProvider = levelDataProvider;
			_heroFactory = heroFactory;
		}

		public void Enter()
		{
			PlaceHero();

			_stateMachine.Enter<BattleLoopState>();
		}

		private void PlaceHero()
		{
			_heroFactory.Create();
		}

		public void Exit()
		{

		}
	}
}