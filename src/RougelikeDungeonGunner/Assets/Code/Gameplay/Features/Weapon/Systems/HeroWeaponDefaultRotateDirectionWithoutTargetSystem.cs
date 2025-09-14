using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class HeroWeaponDefaultRotateDirectionWithoutTargetSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;

		public HeroWeaponDefaultRotateDirectionWithoutTargetSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon,
					GameMatcher.RotationPointTransform)
				.NoneOf(GameMatcher.ClosestTargetPosition));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				weapon.RotationPointTransform.rotation = Quaternion.Euler(0, 0, 0);

				weapon.ReplaceWeaponRotationAngle(default);
			}
		}
	}
}