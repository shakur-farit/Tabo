using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreateAmmoFromStarPatternSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(64);
		private readonly IAmmoFactory _ammoFactory;
		private readonly IGroup<GameEntity> _patterns;

		public CreateAmmoFromStarPatternSystem(GameContext game, IAmmoFactory ammoFactory)
		{
			_ammoFactory = ammoFactory;
			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoPattern,
					GameMatcher.StarPattern,
					GameMatcher.Id,
					GameMatcher.PatternEmpty,
					GameMatcher.AmmoTypeId,
					GameMatcher.WorldPosition,
					GameMatcher.Direction,
					GameMatcher.PatternAmmoCount,
					GameMatcher.PatternRadius,
					GameMatcher.ProducerId));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns.GetEntities(_buffer))
			{
				int branches = 6;

				for (int b = 0; b < branches; b++)
				{
					float baseAngle = (360f / branches) * b;
					Vector3 branchDir = Quaternion.Euler(0, 0, baseAngle) * Vector3.right;

					for (int p = 0; p < pattern.PatternAmmoCount; p++)
					{
						float t = (float)p / (pattern.PatternAmmoCount - 1);
						float maxRadius = t * pattern.PatternRadius;
						float waveOffset = Mathf.Sin(t * Mathf.PI * pattern.PatternAmmoCount) * (pattern.PatternRadius * 0.1f);

						Vector3 offset = branchDir * (maxRadius + waveOffset);
						Vector3 spawnPos = pattern.WorldPosition + offset;

						GameEntity ammo = _ammoFactory.CreateAmmo(pattern.AmmoTypeId, spawnPos);
						ammo
							.AddProducerId(pattern.ProducerId)
							.AddAmmoPatternId(pattern.Id)
							.With(x => x.isMoving = true)
							.With(x => x.isOrbitalMovement = true)
							;

						ammo.ReplaceDirection(pattern.Direction);
					}

					pattern.isPatternEmpty = false;
				}
			}
		}
	}
}