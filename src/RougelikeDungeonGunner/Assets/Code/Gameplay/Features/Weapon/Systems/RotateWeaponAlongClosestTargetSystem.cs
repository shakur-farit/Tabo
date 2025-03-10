using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RotateWeaponAlongClosestTargetSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _hero;

		public RotateWeaponAlongClosestTargetSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Radius,
					GameMatcher.WeaponRotationPointTransform,
					GameMatcher.ClosestTarget));

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
				GameEntity closestTarget = weapon.ClosestTarget;

				RotateWeapon(closestTarget, weapon, hero);
			}
		}

		private void RotateWeapon(GameEntity closestTarget, GameEntity weapon, GameEntity hero)
		{
			Vector3 direction = (closestTarget.WorldPosition - hero.WorldPosition)
				.normalized;
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			weapon.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, angle);

			weapon.ReplaceWeaponRotationAngle(angle);
		}
	}
}