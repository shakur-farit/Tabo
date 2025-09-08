using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class FindClosestHeroTargetSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _targets;
		private readonly IGroup<GameEntity> _weapons;

		public FindClosestHeroTargetSystem(GameContext game)
		{
			_targets = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon,
					GameMatcher.Radius,
					GameMatcher.WeaponRotationPointTransform));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				float closestDistance = float.MaxValue;

				foreach (GameEntity target in _targets)
				{
					float distance = (target.WorldPosition - weapon.WeaponRotationPointTransform.position).magnitude;

					if (distance <= weapon.Radius && distance < closestDistance)
					{
						closestDistance = distance;
						weapon.ReplaceClosestTargetPosition(target.WorldPosition);
					}
				}
			}
		}
	}
}