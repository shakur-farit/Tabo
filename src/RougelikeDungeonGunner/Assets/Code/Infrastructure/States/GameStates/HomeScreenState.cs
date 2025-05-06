using Code.Infrastructure.States.StateInfrastructure;
using Code.Meta;
using Code.Meta.UI.UIRoot.Factory;

namespace Code.Infrastructure.States.GameStates
{
	public class HomeScreenState : IState, IUpdateable
	{
		private HomeScreenFeature _homeScreenFeature;

		private readonly ISystemsFactory _systems;
		private readonly GameContext _gameContext;
		private readonly IUIRootFactory _uiRootFactory;

		public HomeScreenState(
			ISystemsFactory systems,
			GameContext gameContext,
			IUIRootFactory uiRootFactory)
		{
			_systems = systems;
			_gameContext = gameContext;
			_uiRootFactory = uiRootFactory;
		}

		public void Enter()
		{
			_uiRootFactory.CreateUIRoot();

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