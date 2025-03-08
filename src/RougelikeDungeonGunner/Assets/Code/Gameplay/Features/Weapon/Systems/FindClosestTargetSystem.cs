using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class FindClosestTargetSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _targets;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(32);

		public FindClosestTargetSystem(GameContext game)
		{
			_targets = game.GetGroup(GameMatcher
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
				if (weapon.hasClosestTarget)
					weapon.RemoveClosestTarget();

				float closestDistance = float.MaxValue;

				foreach (GameEntity target in _targets.GetEntities(_buffer))
				{
					float distance = (target.WorldPosition - weapon.WeaponRotationPointTransform.position).magnitude;

					if (distance <= weapon.Radius && distance < closestDistance)
					{
						closestDistance = distance;
						weapon.ReplaceClosestTarget(target);
					}
				}
			}
		}
	}
}