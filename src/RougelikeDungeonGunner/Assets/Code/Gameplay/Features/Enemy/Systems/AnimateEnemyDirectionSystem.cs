using Code.Gameplay.Common;
using Code.Gameplay.Common.Direction;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class AnimateEnemyDirectionSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enemies;
		private readonly IGroup<GameEntity> _weapons;

		public AnimateEnemyDirectionSystem(GameContext game)
		{
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.EnemyAnimator,
					GameMatcher.Id,
					GameMatcher.Direction)
				.NoneOf(GameMatcher.Stunned));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyWeapon,
					GameMatcher.WeaponOwnerId,
					GameMatcher.Direction));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			foreach (GameEntity weapon in _weapons)
			{
				if(enemy.Id != weapon.WeaponOwnerId)
						continue;

				float angle = Mathf.Atan2(weapon.Direction.y, weapon.Direction.x) * Mathf.Rad2Deg;

				FacingDirection direction = GetDirectionEnum(angle);
				enemy.EnemyAnimator.SetDirectionEnum(direction);
			}
		}

		private FacingDirection GetDirectionEnum(float angle)
		{
			if (angle >= 22f && angle <= 67f) 
				return FacingDirection.UpRight;
			if (angle > 67f && angle <= 112f) 
				return FacingDirection.Up;
			if (angle > 112f && angle <= 158f) 
				return FacingDirection.UpLeft;
			if ((angle <= 180f && angle > 158f) || (angle > -180f && angle <= -135f)) 
				return FacingDirection.Left;
			if (angle > -135f && angle <= -45f) 
				return FacingDirection.Down;
			if ((angle > -45f && angle <= 0f) || (angle > 0f && angle < 22f)) 
				return FacingDirection.Right;

			return FacingDirection.Up;
		}
	}
}