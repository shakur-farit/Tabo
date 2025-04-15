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
					return CreatePoisonStatus(producerId, targetId, setup);
				case StatusTypeId.Freeze:
					return CreateFreezeStatus(producerId, targetId, setup);
				default:
					throw new Exception($"Status with type id {setup.StatusTypeId} does not exist");
			}
		}

		private GameEntity CreatePoisonStatus(int producerId, int targetId, StatusSetup setup) =>
			CreateStatusEntity(producerId, targetId, setup)
				.With(x => x.isPoison = true)
			;

		private GameEntity CreateFreezeStatus(int producerId, int targetId, StatusSetup setup) =>
			CreateStatusEntity(producerId, targetId, setup)
				.With(x => x.isFreeze = true)
			;

		private GameEntity CreateStatusEntity(int producerId, int targetId, StatusSetup setup)
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