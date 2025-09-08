using System.Collections.Generic;
using Code.Common.Extensions;
using Entitas;

namespace Code.Gameplay.Features.Ammo
{
	public class CreateHealingAuraForHeroSystem : IExecuteSystem
	{
		private const float YAxisOffset = 0.5f;

		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAuraFactory _auraFactory;
		private readonly IGroup<GameEntity> _requesters;

		public CreateHealingAuraForHeroSystem(GameContext game, IAuraFactory auraFactory)
		{
			_auraFactory = auraFactory;
			_requesters = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.RequestHealingAura,
					GameMatcher.Hero,
					GameMatcher.Id,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity requester in _requesters.GetEntities(_buffer))
			{
				GameEntity aura = _auraFactory.CreateAura(AuraTypeId.Healing, requester.WorldPosition);

				aura
					.AddFollowTargetId(requester.Id)
					.AddFollowMovementYAxisOffset(YAxisOffset)
					.AddProducerId(requester.Id)
					.AddTargetsBuffer(new())
					.AddTargetLayerMask(CollisionLayer.Hero.AsMask())
					.AddRadius(aura.AuraRadius)
					.With(x => x.isReadyToCollectTargets = true)
					;

				requester
					.With(x => x.isRequestHealingAura = false)
					.With(x => x.isHealingAuraApplied = true)
					;
			}
		}
	}
}