using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Spawner;
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
		private readonly ISpawnerFactory _spawnerFactory;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelDataProvider levelDataProvider,
			IHeroFactory heroFactory,
			ISpawnerFactory spawnerFactory)
		{
			_stateMachine = stateMachine;
			_levelDataProvider = levelDataProvider;
			_heroFactory = heroFactory;
			_spawnerFactory = spawnerFactory;
		}

		public void Enter()
		{
			PlaceHero();

			_spawnerFactory.CreateEnemySpawner();

			_stateMachine.Enter<BattleLoopState>();
		}

		private void PlaceHero() => 
			_heroFactory.CreateHero(_levelDataProvider.StartPoint);

		public void Exit()
		{

		}
	}
}