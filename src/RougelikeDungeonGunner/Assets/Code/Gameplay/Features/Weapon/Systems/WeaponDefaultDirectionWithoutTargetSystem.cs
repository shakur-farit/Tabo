using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class WeaponDefaultDirectionWithoutTargetSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;

		public WeaponDefaultDirectionWithoutTargetSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Radius,
					GameMatcher.WeaponRotationPointTransform)
				.NoneOf(GameMatcher.ClosestTarget));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons) 
				weapon.WeaponRotationPointTransform.rotation = Quaternion.Euler(0, 0, 0);
		}
	}
}