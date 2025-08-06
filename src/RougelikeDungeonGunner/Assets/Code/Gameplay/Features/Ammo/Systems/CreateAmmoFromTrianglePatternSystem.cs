using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreateAmmoFromTrianglePatternSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(64);
		private readonly IAmmoFactory _ammoFactory;
		private readonly IGroup<GameEntity> _patterns;

		public CreateAmmoFromTrianglePatternSystem(GameContext game, IAmmoFactory ammoFactory)
		{
			_ammoFactory = ammoFactory;
			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoPattern,
					GameMatcher.TrianglePattern,
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
				Vector3[] vertices = new Vector3[3];

				for (int i = 0; i < 3; i++)
				{
					float angle = 120f * i - 90f;
					Vector3 dir = Quaternion.Euler(0, 0, angle) * Vector3.up;
					vertices[i] = pattern.WorldPosition + dir * pattern.PatternRadius;
				}

				float sideLength = Vector3.Distance(vertices[0], vertices[1]);
				float perimeter = sideLength * 3;

				float spacing = perimeter / pattern.PatternAmmoCount;

				for (int i = 0; i < pattern.PatternAmmoCount; i++)
				{
					float distanceAlongPerimeter = spacing * i;

					int sideIndex = (int)(distanceAlongPerimeter / sideLength);
					float sidePos = (distanceAlongPerimeter % sideLength) / sideLength;

					Vector3 spawnPos = Vector3.Lerp(vertices[sideIndex], vertices[(sideIndex + 1) % 3], sidePos);

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