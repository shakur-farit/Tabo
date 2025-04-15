using System.Collections.Generic;
using Code.Common.EntityIndices;
using Code.Common.Extensions;
using Code.Gameplay.Features.Statuses.Factory;

namespace Code.Gameplay.Features.Statuses.Applier
{
	public class StatusApplier : IStatusApplier
	{
		private readonly IStatusFactory _statusFactory;
		private readonly GameContext _game;

		public StatusApplier(IStatusFactory statusFactory, GameContext game)
		{
			_statusFactory = statusFactory;
			_game = game;
		}

		public GameEntity ApplyStatus(StatusSetup setup, int producerId, int targetId)
		{
			HashSet<GameEntity> existingStatuses = _game.TargetStatusOfType(setup.StatusTypeId, targetId);

			foreach (GameEntity status in existingStatuses)
				if (setup.IsIdenticalTo(status))
					return status.ReplaceStatusTimeLeft(setup.StatusDuration);

			return _statusFactory.CreateStatus(setup, producerId, targetId)
				.With(x => x.isApplied = true);
		}
	}
}