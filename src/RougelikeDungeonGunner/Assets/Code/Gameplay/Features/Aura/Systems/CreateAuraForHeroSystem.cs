using System.Collections.Generic;
using Code.Common.Extensions;
using Entitas;

namespace Code.Gameplay.Features.Ammo
{
	public class CreateAuraForHeroSystem : IExecuteSystem
	{
		private const float YAxisOffset = 0.5f;

		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAuraFactory _auraFactory;
		private readonly IGroup<GameEntity> _requesters;

		public CreateAuraForHeroSystem(GameContext game, IAuraFactory auraFactory)
		{
			_auraFactory = auraFactory;
			_requesters = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.RequestAura,
					GameMatcher.Hero,
					GameMatcher.Id,
					GameMatcher.WorldPosition,
					GameMatcher.AuraTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity requester in _requesters.GetEntities(_buffer))
			{
				GameEntity aura = _auraFactory.CreateAura(requester.AuraTypeId, requester.WorldPosition)
					.AddFollowTargetId(requester.Id)
					.AddFollowMovementYAxisOffset(YAxisOffset)
					.AddProducerId(requester.Id);

				aura.ViewPrefab.gameObject.layer = (int)CollisionLayer.Hero;

				requester
					.RemoveAuraTypeId()
					.With(x => x.isRequestAura = false)
					.With(x => x.isShieldApplied = true)
					;
			}
		}
	}
}