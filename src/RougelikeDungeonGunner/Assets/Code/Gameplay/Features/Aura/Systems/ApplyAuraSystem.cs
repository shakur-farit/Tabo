using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	public class ApplyAuraSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAuraFactory _auraFactory;
		private readonly IGroup<GameEntity> _pickupers;

		public ApplyAuraSystem(GameContext game, IAuraFactory auraFactory)
		{
			_auraFactory = auraFactory;
			_pickupers = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AuraPickedUp,
					GameMatcher.WorldPosition,
					GameMatcher.AuraTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity pickuper in _pickupers.GetEntities(_buffer))
			{
				_auraFactory.CreateAura(pickuper.AuraTypeId, pickuper.WorldPosition)
					.AddFollowTargetId(pickuper.Id)
					.AddFollowMovementYAxisOffset(0.5f);

				pickuper.isAuraPickedUp = false;
			}
		}
	}
}