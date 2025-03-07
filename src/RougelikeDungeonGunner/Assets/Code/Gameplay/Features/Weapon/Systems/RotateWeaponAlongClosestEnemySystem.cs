using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RotateWeaponAlongClosestEnemySystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(32);

		private readonly IGroup<GameEntity> _enemies;
		private readonly IGroup<GameEntity> _weapons;

		public RotateWeaponAlongClosestEnemySystem(GameContext game)
		{

			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Radius,
					GameMatcher.WeaponRotationPointTransform));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				GameEntity closestEnemy = ClosestEnemy(weapon);

				if (closestEnemy != null)
				{
					Vector3 direction = (closestEnemy.WorldPosition - weapon.WeaponRotationPointTransform.position)
						.normalized;
					float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
					weapon.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, angle);
				}
				else
				{
					weapon.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, 0);
				}
			}
		}

		private GameEntity ClosestEnemy(GameEntity weapon)
		{
			GameEntity closestEnemy = null;
			float closestDistance = float.MaxValue;
			Vector3 weaponPosition = weapon.WeaponRotationPointTransform.position;
			float weaponRange = weapon.Radius;

			foreach (GameEntity enemy in _enemies.GetEntities(_buffer))
			{
				float distance = (enemy.WorldPosition - weaponPosition).magnitude;
				if (distance <= weaponRange && distance < closestDistance)
				{
					closestDistance = distance;
					closestEnemy = enemy;
				}
			}

			return closestEnemy;
		}
	}
}