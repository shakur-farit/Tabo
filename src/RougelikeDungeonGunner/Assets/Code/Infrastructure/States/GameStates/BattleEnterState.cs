using Code.Gameplay.Features.Abilities.Factory;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Hero.Factory;
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
		private readonly IAbilityFactory _abilityFactory;
		private readonly IWeaponFactory _weaponFactory;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelDataProvider levelDataProvider,
			IHeroFactory heroFactory,
			IAbilityFactory abilityFactory,
			IWeaponFactory weaponFactory)
		{
			_stateMachine = stateMachine;
			_levelDataProvider = levelDataProvider;
			_heroFactory = heroFactory;
			_abilityFactory = abilityFactory;
			_weaponFactory = weaponFactory;
		}

		public void Enter()
		{
			PlaceHero();

			_stateMachine.Enter<BattleLoopState>();
		}

		private void PlaceHero()
		{
			_heroFactory.CreateHero(_levelDataProvider.StartPoint);
			
			_abilityFactory.CreatePistolBulletAbility(1);

			_weaponFactory.CreatePistol();
		}

		public void Exit()
		{

		}
	}
}