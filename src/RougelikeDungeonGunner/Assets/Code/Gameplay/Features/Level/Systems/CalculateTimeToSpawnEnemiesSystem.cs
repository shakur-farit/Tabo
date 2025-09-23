using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Level.Systems
{
	public class CalculateTimeToSpawnEnemiesSystem : IExecuteSystem
	{
		private const string TimeText = "Time to level start";

		private readonly List<GameEntity> _buffer = new(1);

		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _holders;

		public CalculateTimeToSpawnEnemiesSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level,
					GameMatcher.StartingTime,
					GameMatcher.StartingTimeLeft)
				.NoneOf(GameMatcher.StartingTimeUp));

			_holders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.TimerHolder));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			foreach (GameEntity holder in _holders)
			{
				if (level.StartingTimeLeft <= 0)
				{
					level.isStartingTimeUp = true;
					level.ReplaceStartingTimeLeft(level.StartingTime);
					holder.TimerHolder.HideTimeText();
				}
				else
				{
					level.ReplaceStartingTimeLeft(level.StartingTimeLeft - _time.DeltaTime);
					holder.TimerHolder.UpdateTimeText(TimeText, level.StartingTimeLeft);
				}
			}
		}
	}
}