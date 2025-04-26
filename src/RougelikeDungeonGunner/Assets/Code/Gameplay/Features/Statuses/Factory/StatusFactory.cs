using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Statuses.Factory
{
	public class StatusFactory : IStatusFactory
	{
		private readonly IIdentifierService _identifier;

		public StatusFactory(IIdentifierService identifier) =>
			_identifier = identifier;

		public GameEntity CreateStatus(StatusSetup setup, int producerId, int targetId)
		{
			switch (setup.StatusTypeId)
			{
				case StatusTypeId.Poison:
					return CreatePoisonStatus(setup, producerId, targetId);
				case StatusTypeId.Freeze:
					return CreateFreezeStatus(setup, producerId, targetId);
				case StatusTypeId.Flame:
					return CreateFlameStatus(setup, producerId, targetId);
			}
			
			throw new Exception($"Status with type id {setup.StatusTypeId} does not exist");
		}

		private GameEntity CreatePoisonStatus(StatusSetup setup, int producerId, int targetId) =>
			CreateStatusEntity(setup, producerId, targetId)
				.With(x => x.isPoison = true)
			;

		private GameEntity CreateFreezeStatus(StatusSetup setup, int producerId, int targetId) =>
			CreateStatusEntity(setup, producerId, targetId)
				.With(x => x.isFreeze = true)
			;

		private GameEntity CreateFlameStatus(StatusSetup setup, int producerId, int targetId) =>
			CreateStatusEntity(setup, producerId, targetId)
				.With(x => x.isFlame = true)
		;

		private GameEntity CreateStatusEntity(StatusSetup setup, int producerId, int targetId)
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddStatusTypeId(setup.StatusTypeId)
					.AddEffectValue(setup.Value)
					.AddProducerId(producerId)
					.AddTargetId(targetId)
					.With(x => x.isStatus = true)
					.With(x => x.AddStatusDuration(setup.StatusDuration), when: setup.StatusDuration > 0)
					.With(x => x.AddStatusTimeLeft(setup.StatusDuration), when: setup.StatusDuration > 0)
					.With(x => x.AddPeriod(setup.Period), when: setup.Period > 0)
					.With(x => x.AddTimeSinceLastTick(0), when: setup.Period > 0)
				;
		}
	}
}