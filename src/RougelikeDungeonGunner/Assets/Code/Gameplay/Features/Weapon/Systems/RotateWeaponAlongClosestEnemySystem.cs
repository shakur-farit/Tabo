using Entitas;
using System.Linq;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RotateWeaponAlongClosestEnemySystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _enemies;

		public RotateWeaponAlongClosestEnemySystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponRotationPointTransform)); 
			
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				Vector3 direction = (FirstAvailableTarget().WorldPosition - weapon.WeaponRotationPointTransform.position).normalized;
				float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
				weapon.WeaponRotationPointTransform.rotation = Quaternion.Euler(0,0, angle);
			}
		}

		private GameEntity FirstAvailableTarget() => 
			_enemies.AsEnumerable().First();
	}
}