using Code.Gameplay.Features.Hero.States;
using Code.Gameplay.Features.Hero.States.StateMachine;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class AnimateHeroAimingSystem : IExecuteSystem
	{
		private const float Hysteresis = 5f;

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
			var animator = hero.HeroAnimator;
			float angle = weapon.WeaponRotationAngle;

			if (angle >= 22f - Hysteresis && angle <= 67f + Hysteresis)
				_stateMachine.Enter<AimUpRightAnimationState>(animator);
			else if (angle > 67f - Hysteresis && angle <= 112f + Hysteresis)
				_stateMachine.Enter<AimUpAnimationState>(animator);
			else if (angle > 112f - Hysteresis && angle <= 158f + Hysteresis)
				_stateMachine.Enter<AimUpLeftAnimationState>(animator);
			else if ((angle <= 180f && angle > 158f - Hysteresis) || (angle > -180f && angle <= -135f + Hysteresis))
				_stateMachine.Enter<AimLeftAnimationState>(animator);
			else if (angle > -135f - Hysteresis && angle <= -45f + Hysteresis)
				_stateMachine.Enter<AimDownAnimationState>(animator);
			else if ((angle > -45f - Hysteresis && angle <= 0f) || (angle > 0f && angle < 22f + Hysteresis))
				_stateMachine.Enter<AimRightAnimationState>(animator);
		}
	}
}