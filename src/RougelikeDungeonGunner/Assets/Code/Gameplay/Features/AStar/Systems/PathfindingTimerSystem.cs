using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class PathfindingTimerSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _pathfinders;

		public PathfindingTimerSystem(GameContext game, ITimeService time)
		{
			_time = time;
			_pathfinders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Pathfinder,
					GameMatcher.PathfindingIntervalTimer,
					GameMatcher.PathfindingTimerLeft));
		}

		public void Execute()
		{
			foreach (GameEntity pathfinder in _pathfinders.GetEntities(_buffer))
			{
				if (pathfinder.PathfindingTimerLeft > 0)
					pathfinder.ReplacePathfindingTimerLeft(pathfinder.PathfindingTimerLeft - _time.DeltaTime);
				else
				{
					pathfinder.ReplacePathfindingTimerLeft(pathfinder.PathfindingIntervalTimer);
					pathfinder.isPathfindingTimerUp = true;
				}
			}
		}
	}
}