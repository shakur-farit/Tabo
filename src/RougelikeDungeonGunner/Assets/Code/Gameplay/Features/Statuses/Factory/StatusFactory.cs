using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Effects;
using Code.Infrastructure.Identifiers;
using TMPro.EditorUtilities;
using UnityEngine;

namespace Code.Gameplay.Features.Statuses.Factory
{
	public class StatusFactory : IStatusFactory
	{
		private const int TargetsBufferSize = 16;

		private readonly IIdentifierService _identifier;
		private readonly GameContext _game;

		public StatusFactory(IIdentifierService identifier, GameContext game)
		{
			_identifier = identifier;
			_game = game;
		}

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
			CreateStatusEntity(setup, producerId)
				.AddTargetId(targetId)
				.With(x => x.isPoison = true)
			;

		private GameEntity CreateFreezeStatus(StatusSetup setup, int producerId, int targetId) =>
			CreateStatusEntity(setup, producerId)
				.AddTargetId(targetId)
				.With(x => x.isFreeze = true)
			;

		private GameEntity CreateFlameStatus(StatusSetup setup, int producerId, int targetId)
		{
			GameEntity target = _game.GetEntityWithId(targetId);

			return CreateStatusEntity(setup, producerId)
				.AddWorldPosition(target.WorldPosition)
				.AddTargetsBuffer(new List<int>(TargetsBufferSize))
				.AddProcessedTargets(new List<int>(TargetsBufferSize))
				.AddLayerMask(CollisionLayer.Enemy.AsMask())
				.With(x => x.isFlame = true)
				.With(x => x.isReadyToCollectTargets = true)
				.With(x => x.isCollectTargetsContinuously = true);
		}

		private GameEntity CreateStatusEntity(StatusSetup setup, int producerId)
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddStatusTypeId(setup.StatusTypeId)
					.AddEffectValue(setup.Value)
					.AddProducerId(producerId)
					.With(x => x.isStatus = true)
					.With(x => x.AddStatusDuration(setup.StatusDuration), when: setup.StatusDuration > 0)
					.With(x => x.AddStatusTimeLeft(setup.StatusDuration), when: setup.StatusDuration > 0)
					.With(x => x.AddPeriod(setup.Period), when: setup.Period > 0)
					.With(x => x.AddTimeSinceLastTick(0), when: setup.Period > 0)
					.With(x => x.AddRadius(setup.Radius), when: setup.Radius > 0)
				;
		}
	}
}