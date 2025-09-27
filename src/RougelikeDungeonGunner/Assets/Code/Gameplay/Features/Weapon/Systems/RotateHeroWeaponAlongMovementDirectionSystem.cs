using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class RotateHeroWeaponAlongMovementDirectionSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _hero;

		public RotateHeroWeaponAlongMovementDirectionSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon,
					GameMatcher.RotationPointTransform)
				.NoneOf(GameMatcher.ClosestTargetPosition));

			_hero = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Direction,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _hero)
			foreach (GameEntity weapon in _weapons)
			{
				float angle = Mathf.Atan2(hero.Direction.y, hero.Direction.x) * Mathf.Rad2Deg;
				weapon.RotationPointTransform.rotation = Quaternion.Euler(0, 0, angle);

				weapon.ReplaceWeaponRotationAngle(angle);
			}
		}
	}
}