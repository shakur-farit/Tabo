using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Effects;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
	public class StatusDurationSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _statuses;

		public StatusDurationSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_statuses = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Status,
					GameMatcher.StatusTimeLeft));
		}

		public void Execute()
		{
			foreach (GameEntity status in _statuses)
			{
				if (status.StatusTimeLeft >= 0)
					status.ReplaceStatusTimeLeft(status.StatusTimeLeft - _time.DeltaTime);
				else
				{
					if(status.Target() != null)
						status.Target()
						.isStunned = false;

					status.isUnapplied = true;
				}
			}
		}
	}
}