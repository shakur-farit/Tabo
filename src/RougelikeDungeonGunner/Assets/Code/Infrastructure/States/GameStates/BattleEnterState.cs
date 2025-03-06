using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Factory;
using Code.Gameplay.Levels;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using UnityEngine;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleEnterState : IState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelDataProvider _levelDataProvider;
		private readonly IHeroFactory _heroFactory;
		private readonly IWeaponFactory _weaponFactory;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelDataProvider levelDataProvider,
			IHeroFactory heroFactory,
			IWeaponFactory weaponFactory)
		{
			_stateMachine = stateMachine;
			_levelDataProvider = levelDataProvider;
			_heroFactory = heroFactory;
			_weaponFactory = weaponFactory;
		}

		public void Enter()
		{
			PlaceHero();

			_stateMachine.Enter<BattleLoopState>();
		}

		private void PlaceHero() => 
			_heroFactory.CreateHero(_levelDataProvider.StartPoint);

		public void Exit()
		{

		}
	}
}