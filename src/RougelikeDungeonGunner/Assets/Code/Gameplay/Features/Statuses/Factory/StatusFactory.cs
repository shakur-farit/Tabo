using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Statuses.Factory
{
	public class StatusFactory : IStatusFactory
	{
		private readonly IIdentifierService _identifier;

		public StatusFactory(IIdentifierService identifier)
		{
			_identifier = identifier;
		}

		public GameEntity CreateStatus(StatusSetup setup, int producerId, int targetId)
		{
			GameEntity status;

			switch (setup.StatusTypeId)
			{
				case StatusTypeId.Poison:
					status = CreatePoisonStatus(producerId, targetId, setup);
					break;
				case StatusTypeId.Freeze:
					status = CreateFreezeStatus(producerId, targetId, setup);
					break;

				default:
					throw new Exception($"Status with type id {setup.StatusTypeId} does not exist");
			}

			status
				.With(x => x.AddDuration(setup.Duration), when: setup.Duration > 0)
				.With(x => x.AddTimeLeft(setup.Duration), when: setup.Duration > 0)
				.With(x => x.AddPeriod(setup.Period), when: setup.Period > 0)
				.With(x => x.AddTimeSinceLastTick(0), when: setup.Period > 0)
				;

			return status;
		}

		private GameEntity CreatePoisonStatus(int producerId, int targetId, StatusSetup setup)
		{
			return CreateStatusEntity(producerId, targetId, setup)
					.AddStatusTypeId(StatusTypeId.Poison)
					.With(x => x.isPoison = true)
				;
		}

		private GameEntity CreateFreezeStatus(int producerId, int targetId, StatusSetup setup)
		{
			return CreateStatusEntity(producerId, targetId, setup)
					.AddStatusTypeId(StatusTypeId.Freeze)
					.With(x => x.isFreeze = true)
				;
		}

		private GameEntity CreateStatusEntity(int producerId, int targetId, StatusSetup setup)
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddEffectValue(setup.Value)
					.AddProducerId(producerId)
					.AddTargetId(targetId)
					.With(x => x.isStatus = true)
				;
		}
	}
}