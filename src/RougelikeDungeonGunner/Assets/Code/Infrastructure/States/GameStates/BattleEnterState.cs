using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Levels;
using Code.Gameplay.Features.Spawner.Factory;
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
		private readonly ISpawnerFactory _spawnerFactory;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelDataProvider levelDataProvider,
			IHeroFactory heroFactory,
			ILevelFactory levelFactory,
			ISpawnerFactory spawnerFactory)
		{
			_stateMachine = stateMachine;
			_levelDataProvider = levelDataProvider;
			_heroFactory = heroFactory;
			_levelFactory = levelFactory;
			_spawnerFactory = spawnerFactory;

		}

		public void Enter()
		{
			_levelFactory.CreateLevel(LevelTypeId.First);

			PlaceHero();

			_spawnerFactory.CreateEnemySpawner();

			_stateMachine.Enter<BattleLoopState>();
		}

		private void PlaceHero() => 
			_heroFactory.CreateHero(HeroTypeId.TheGeneral, _levelDataProvider.StartPoint);

		public void Exit()
		{

		}
	}
}