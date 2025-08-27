using System.Collections.Generic;
using Code.Common.Extensions;
using Entitas;

namespace Code.Gameplay.Features.Ammo
{
	public class CreateShieldForEnemySystem : IExecuteSystem
	{
		private const float YAxisOffset = 0.5f;

		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAuraFactory _auraFactory;
		private readonly IGroup<GameEntity> _requesters;

		public CreateShieldForEnemySystem(GameContext game, IAuraFactory auraFactory)
		{
			_auraFactory = auraFactory;
			_requesters = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.RequestShield,
					GameMatcher.Enemy,
					GameMatcher.Id,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity requester in _requesters.GetEntities(_buffer))
			{
				GameEntity aura = _auraFactory.CreateAura(AuraTypeId.Shield, requester.WorldPosition);

				aura
					.AddAuraLayer((int)CollisionLayer.Enemy)
					.AddFollowTargetId(requester.Id)
					.AddFollowMovementYAxisOffset(YAxisOffset)
					.AddProducerId(requester.Id);

				requester
					.With(x => x.isRequestShield = false)
					.With(x => x.isShieldApplied = true)
					;
			}
		}
	}
}