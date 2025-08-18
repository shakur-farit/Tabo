using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreateAmmoFromSinglePatternSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(64);
		private readonly IAmmoFactory _ammoFactory;
		private readonly IGroup<GameEntity> _patterns;

		public CreateAmmoFromSinglePatternSystem(GameContext game, IAmmoFactory ammoFactory)
		{
			_ammoFactory = ammoFactory;
			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoPattern,
					GameMatcher.SinglePattern,
					GameMatcher.Id,
					GameMatcher.PatternEmpty,
					GameMatcher.AmmoTypeId,
					GameMatcher.WorldPosition,
					GameMatcher.Speed,
					GameMatcher.Direction,
					GameMatcher.ProducerId));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns.GetEntities(_buffer))
			{
				GameEntity ammo = _ammoFactory.CreateAmmo(pattern.AmmoTypeId, pattern.WorldPosition);
				ammo
					.AddProducerId(pattern.ProducerId)
					.AddAmmoPatternId(pattern.Id)
					.AddFollowTargetId(pattern.Id)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isMoving = true)
					.With(x => x.isFollowMovement = true)
					;

				ammo.ReplaceDirection(pattern.Direction);

				pattern.isPatternEmpty = false;
			}
		}
	}
}