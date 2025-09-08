using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RotateHeroWeaponAlongClosestTargetSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _hero;

		public RotateHeroWeaponAlongClosestTargetSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon,
					GameMatcher.WeaponRotationPointTransform,
					GameMatcher.ClosestTargetPosition));

			_hero = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _hero)
			foreach (GameEntity weapon in _weapons)
			{
				Vector3 closestTargetPosition = weapon.ClosestTargetPosition;

				RotateWeapon(closestTargetPosition, weapon, hero);
			}
		}

		private void RotateWeapon(Vector3 closestTargetPosition, GameEntity weapon, GameEntity hero)
		{
			Vector3 direction = (closestTargetPosition - hero.WorldPosition)
				.normalized;
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			weapon.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, angle);

			weapon.ReplaceWeaponRotationAngle(angle);
		}
	}
}