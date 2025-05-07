using Code.Infrastructure.States.StateInfrastructure;
using Code.Meta;

namespace Code.Infrastructure.States.GameStates
{
	public class HomeScreenState : IState, IUpdateable
	{
		private HomeScreenFeature _homeScreenFeature;

		private readonly ISystemsFactory _systems;
		private readonly GameContext _gameContext;

		public HomeScreenState(
			ISystemsFactory systems,
			GameContext gameContext)
		{
			_systems = systems;
			_gameContext = gameContext;
		}

		public void Enter()
		{
			_homeScreenFeature = _systems.Create<HomeScreenFeature>();
			_homeScreenFeature.Initialize();
		}

		public void Update()
		{
			_homeScreenFeature.Execute();
			_homeScreenFeature.Cleanup();
		}

		public void Exit()
		{
			_homeScreenFeature.DeactivateReactiveSystems();
			_homeScreenFeature.ClearReactiveSystems();

			DestructEntities();

			_homeScreenFeature.Cleanup();
			_homeScreenFeature.TearDown();
			_homeScreenFeature = null;
		}

		private void DestructEntities()
		{
			foreach (GameEntity entity in _gameContext.GetEntities())
				entity.isDestructed = true;
		}
	}
}