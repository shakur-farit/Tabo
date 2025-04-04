using Code.Gameplay.Features.Hero.Behaviours;
using Code.Gameplay.Features.Hero.States.HeroAnimationStates;
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
				AnimateRotation(weapon.WeaponRotationAngle, hero.HeroAnimator);
		}

		private void AnimateRotation(float angle, HeroAnimator animator)
		{
			if (angle >= 22f && angle <= 67f)
				_stateMachine.Enter<AimUpRightAnimationState>(animator);
			else if (angle > 67f && angle <= 112f)
				_stateMachine.Enter<AimUpAnimationState>(animator);
			else if (angle > 112f && angle <= 158f)
				_stateMachine.Enter<AimUpLeftAnimationState>(animator);
			else if ((angle <= 180f && angle > 158f ) || (angle > -180f && angle <= -135f))
				_stateMachine.Enter<AimLeftAnimationState>(animator);
			else if (angle > -135f && angle <= -45f)
				_stateMachine.Enter<AimDownAnimationState>(animator);
			else if ((angle > -45f && angle <= 0f) || (angle > 0f && angle < 22f))
				_stateMachine.Enter<AimRightAnimationState>(animator);
		}
	}
}