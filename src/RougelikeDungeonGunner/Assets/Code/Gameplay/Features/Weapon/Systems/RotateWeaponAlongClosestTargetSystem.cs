using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RotateWeaponAlongClosestTargetSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(32);

		private readonly IGroup<GameEntity> _weapons;

		public RotateWeaponAlongClosestTargetSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Radius,
					GameMatcher.WeaponRotationPointTransform,
					GameMatcher.ClosestTarget));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				GameEntity closestTarget = weapon.ClosestTarget;

				Vector3 direction = (closestTarget.WorldPosition - weapon.WeaponRotationPointTransform.position)
					.normalized;
				float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
				weapon.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, angle);
			}
		}
	}
}