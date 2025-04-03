using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Levels;
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
		private readonly ILevelFactory _levelFactory;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelDataProvider levelDataProvider,
			IHeroFactory heroFactory,
			ILevelFactory levelFactory)
		{
			_stateMachine = stateMachine;
			_levelDataProvider = levelDataProvider;
			_heroFactory = heroFactory;
			_levelFactory = levelFactory;

		}

		public void Enter()
		{
			_levelFactory.CreateLevel(LevelTypeId.First);

			//PlaceHero();

			_stateMachine.Enter<BattleLoopState>();
		}

		private void PlaceHero() => 
			_heroFactory.CreateHero(HeroTypeId.TheGeneral, _levelDataProvider.StartPoint);

		public void Exit()
		{

		}
	}
}