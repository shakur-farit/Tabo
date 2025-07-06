using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Levels.Systems
{
	public class CalculateTimeToSpawnEnemiesSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _levels;

		public CalculateTimeToSpawnEnemiesSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level,
					GameMatcher.StartingTime,
					GameMatcher.StartingTimeLeft));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			{
				if (level.StartingTimeLeft <= 0)
				{
					level.isStartingTimeUp = true;
					level.ReplaceStartingTimeLeft(level.StartingTime);
				}
				else
				{
					level.ReplaceStartingTimeLeft(level.StartingTimeLeft - _time.DeltaTime);
				}
			}
		}
	}
}