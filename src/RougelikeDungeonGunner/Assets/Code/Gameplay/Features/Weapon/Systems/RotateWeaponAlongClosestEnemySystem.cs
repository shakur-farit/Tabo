using Entitas;
using System.Linq;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RotateWeaponAlongClosestEnemySystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _rotationPoints;
		private readonly IGroup<GameEntity> _enemies;
		private readonly IGroup<GameEntity> _weapons;

		public RotateWeaponAlongClosestEnemySystem(GameContext game)
		{
			_rotationPoints = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponRotationPointTransform));

			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Radius));
		}

		public void Execute()
		{
			foreach (GameEntity rotationPoint in _rotationPoints)
			foreach (GameEntity weapon in _weapons)
			{
				GameEntity closestEnemy = ClosestEnemy(rotationPoint, weapon);

				if (closestEnemy != null)
				{
					Vector3 direction = (closestEnemy.WorldPosition - rotationPoint.WeaponRotationPointTransform.position)
						.normalized;
					float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
					rotationPoint.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, angle);
				}
				else
				{
					rotationPoint.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, 0);
				}
			}
		}

		private GameEntity ClosestEnemy(GameEntity rotationPoint, GameEntity weapon)
		{
			Vector3 weaponPosition = rotationPoint.WeaponRotationPointTransform.position;
			float weaponRange = weapon.Radius;

			return _enemies.GetEntities()
				.Where(enemy => Vector3.Distance(enemy.WorldPosition, weaponPosition) <= weaponRange)
				.OrderBy(enemy => Vector3.Distance(enemy.WorldPosition, weaponPosition))
				.FirstOrDefault();
		}
	}
}