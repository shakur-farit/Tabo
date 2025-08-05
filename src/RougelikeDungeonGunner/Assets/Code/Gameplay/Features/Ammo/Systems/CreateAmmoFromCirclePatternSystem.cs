using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreateAmmoFromCirclePatternSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(64);
		private readonly IAmmoFactory _ammoFactory;
		private readonly IGroup<GameEntity> _patterns;

		public CreateAmmoFromCirclePatternSystem(GameContext game, IAmmoFactory ammoFactory)
		{
			_ammoFactory = ammoFactory;
			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoPattern,
					GameMatcher.CirclePattern,
					GameMatcher.Id,
					GameMatcher.PatternEmpty,
					GameMatcher.AmmoTypeId,
					GameMatcher.PatternCenter,
					GameMatcher.Direction,
					GameMatcher.PatternAmmoCount,
					GameMatcher.PatternRadius,
					GameMatcher.ProducerId));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns.GetEntities(_buffer))
			{
				for (int i = 0; i < pattern.PatternAmmoCount; i++)
				{
					float angle = (360f / pattern.PatternAmmoCount) * i;
					Vector3 offset = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad),
						Mathf.Sin(angle * Mathf.Deg2Rad), 0f) * pattern.PatternRadius;

					Vector3 spawnPosition = pattern.PatternCenter + offset;

					GameEntity ammo = _ammoFactory.CreateAmmo(pattern.AmmoTypeId, spawnPosition);
					ammo
						.AddProducerId(pattern.ProducerId)
						.AddAmmoPatternId(pattern.Id)
						.With(x => x.isMoving = true);
					
					ammo.ReplaceDirection(pattern.Direction);
				}

				pattern.isPatternEmpty = false;
			}
		}
	}
}