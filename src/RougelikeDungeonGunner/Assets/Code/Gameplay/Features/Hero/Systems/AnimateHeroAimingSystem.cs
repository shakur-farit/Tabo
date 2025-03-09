using Code.Gameplay.Features.Hero.States;
using Code.Gameplay.Features.Hero.States.StateMachine;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class AnimateHeroAimingSystem : IExecuteSystem
	{
		private readonly IHeroAnimationStateMachine _stateMachine;
		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _weapons;

		public AnimateHeroAimingSystem(
			GameContext game, 
			IHeroAnimationStateMachine stateMachine)
		{
			_stateMachine = stateMachine;
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.HeroAnimator));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponRotationAngle));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity weapon in _weapons)
				AnimateRotation(weapon, hero);
		}

		private void AnimateRotation(GameEntity weapon, GameEntity hero)
		{
			if (weapon.WeaponRotationAngle >= 22f && weapon.WeaponRotationAngle <= 67f)
				_stateMachine.Enter<AimUpRightAnimationState>(hero.HeroAnimator);
			else if (weapon.WeaponRotationAngle > 67f && weapon.WeaponRotationAngle <= 112f)
				_stateMachine.Enter<AimUpAnimationState>(hero.HeroAnimator);
			else if (weapon.WeaponRotationAngle > 112f && weapon.WeaponRotationAngle <= 158f)
				_stateMachine.Enter<AimUpLeftAnimationState>(hero.HeroAnimator);
			else if ((weapon.WeaponRotationAngle <= 180f && weapon.WeaponRotationAngle > 158f) ||
			         (weapon.WeaponRotationAngle > -180f && weapon.WeaponRotationAngle <= -135f))
				_stateMachine.Enter<AimLeftAnimationState>(hero.HeroAnimator);
			else if (weapon.WeaponRotationAngle > -135f && weapon.WeaponRotationAngle <= -45)
				_stateMachine.Enter<AimDownAnimationState>(hero.HeroAnimator);
			else if ((weapon.WeaponRotationAngle > -45f && weapon.WeaponRotationAngle <= 0f) ||
			         (weapon.WeaponRotationAngle > 0f && weapon.WeaponRotationAngle < 22f))
				_stateMachine.Enter<AimRightAnimationState>(hero.HeroAnimator);
			else
				_stateMachine.Enter<AimRightAnimationState>(hero.HeroAnimator);

		}
	}
}