using Code.Gameplay.Common.Direction;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class AnimateHeroAimingSystem : IExecuteSystem
	{
		private const int Hysteresis = 5;

		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _weapons;

		public AnimateHeroAimingSystem(GameContext game)
		{
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
			{
				FacingDirection direction = GetDirectionEnum(weapon.WeaponRotationAngle);
				hero.HeroAnimator.SetDirectionEnum(direction);
			}
		}

		private FacingDirection GetDirectionEnum(float angle)
		{
			if (angle >= 22f + Hysteresis && angle <= 67f - Hysteresis)
				return FacingDirection.UpRight;
			if (angle > 67f + Hysteresis && angle <= 112f - Hysteresis)
				return FacingDirection.Up;
			if (angle > 112f + Hysteresis && angle <= 158f - Hysteresis)
				return FacingDirection.UpLeft;
			if ((angle <= 180f && angle > 158f + Hysteresis) || (angle > -180f && angle <= -135f - Hysteresis))
				return FacingDirection.Left;
			if (angle > -135f + Hysteresis && angle <= -45f - Hysteresis)
				return FacingDirection.Down;
			if ((angle > -45f + Hysteresis && angle <= 0f) || (angle > 0f && angle < 22f - Hysteresis))
				return FacingDirection.Right;

			return FacingDirection.Up;
		}
	}
}