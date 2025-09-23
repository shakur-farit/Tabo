using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class SetWeaponDirectionSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;

		public SetWeaponDirectionSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponRotationAngle,
					GameMatcher.Direction));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				float angle = weapon.WeaponRotationAngle;
				Vector2 direction = new Vector2(
					Mathf.Cos(angle * Mathf.Deg2Rad), 
					Mathf.Sin(angle * Mathf.Deg2Rad)).normalized;

				weapon.ReplaceDirection(direction);
			}
		}
	}
}