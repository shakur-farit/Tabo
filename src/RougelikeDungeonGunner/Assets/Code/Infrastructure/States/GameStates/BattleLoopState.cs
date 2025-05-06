using Code.Gameplay;
using Code.Infrastructure.States.StateInfrastructure;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleLoopState : IState, IUpdateable
	{
		private BattleFeature _battleFeature;

		private readonly ISystemsFactory _systemsFactory;
		private readonly GameContext _gameContext;

		public BattleLoopState(ISystemsFactory systemsFactory, GameContext gameContext)
		{
			_systemsFactory = systemsFactory;
			_gameContext = gameContext;
		}

		public void Enter()
		{
			_battleFeature = _systemsFactory.Create<BattleFeature>();
			_battleFeature.Initialize();
		}

		public void Update()
		{
			_battleFeature.Execute();
			_battleFeature.Cleanup();
		}

		public void Exit()
		{
			_battleFeature.DeactivateReactiveSystems();
			_battleFeature.ClearReactiveSystems();

			DestructEntities();

			_battleFeature.Cleanup();
			_battleFeature.TearDown();
			_battleFeature = null;
		}

		private void DestructEntities()
		{
			foreach (GameEntity entity in _gameContext.GetEntities())
				entity.isDestructed = true;
		}
	}
}	