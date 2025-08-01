using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RotateEnemyWeaponAlongHeroSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _hero;
		private readonly IGroup<GameEntity> _enemies;

		public RotateEnemyWeaponAlongHeroSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.EnemyWeapon,
					GameMatcher.WeaponRotationPointTransform));

			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));

			_hero = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			foreach (GameEntity hero in _hero)
			foreach (GameEntity weapon in _weapons)
			{
				Vector3 targetPosition = hero.WorldPosition;

				RotateWeapon(targetPosition, weapon, enemy);
			}
		}

		private void RotateWeapon(Vector3 targetPosition, GameEntity weapon, GameEntity enemy)
		{
			Vector3 direction = (targetPosition - enemy.WorldPosition)
				.normalized;
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			weapon.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, angle);

			weapon.ReplaceWeaponRotationAngle(angle);
		}
	}
}