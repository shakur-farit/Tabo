using Code.Gameplay.Features;
using Code.Infrastructure.States.StateInfrastructure;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleLoopState : IState, IUpdateable
	{
		private BattleFeature _battleFeature;

		private readonly ISystemsFactory _systemsFactory;

		public BattleLoopState(ISystemsFactory systemsFactory)
		{
			_systemsFactory = systemsFactory;
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
			
		}
	}
}