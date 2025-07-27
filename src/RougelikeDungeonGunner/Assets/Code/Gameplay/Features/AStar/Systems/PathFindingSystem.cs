using System.Collections.Generic;
using Assets.Code.Gameplay.Features.AStar;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class PathFindingSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _chasersBuffer = new(32);
		private readonly List<GameEntity> _pathfindersBuffer = new(1);

		private readonly IAStarPathfinder _pathfinding;
		private readonly IGroup<GameEntity> _chasers;
		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _pathfinders;

		public PathFindingSystem(GameContext game, IAStarPathfinder pathfinding)
		{
			_pathfinding = pathfinding;
			_chasers = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.LastTargetPosition,
					GameMatcher.WorldPosition));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));

			_pathfinders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Pathfinder,
					GameMatcher.MinDistanceForRepath,
					GameMatcher.ValidPositions,
					GameMatcher.PathfindingTimerUp,
					GameMatcher.PathfinderInitialized));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity pathfinder in _pathfinders.GetEntities(_pathfindersBuffer))
			foreach (GameEntity chaser in _chasers.GetEntities(_chasersBuffer))
			{
				if (IsHeroChangePosition(chaser.LastTargetPosition, hero.WorldPosition, pathfinder.MinDistanceForRepath))
				{
					Vector2Int chaserPosition = Vector2Int.FloorToInt(chaser.WorldPosition);
					Vector2Int heroPosition = Vector2Int.FloorToInt(hero.WorldPosition);

					List<Vector2Int> path = _pathfinding
						.FindPath(chaserPosition, heroPosition);

					if (path == null)
						continue;

					DrawDebugPath(path[0], path, Color.yellow);

					chaser.ReplacePath(path);

					chaser.ReplaceLastTargetPosition(hero.WorldPosition);
					pathfinder.isPathfindingTimerUp = false;
				}
			}
		}

		private bool IsHeroChangePosition(Vector2 lastPosition, Vector2 currentPosition, float minDistance)
		{
			float distance = Vector2.Distance(lastPosition, currentPosition);

			return distance > minDistance;
		}

		private void DrawDebugPath(Vector2Int start, List<Vector2Int> path, Color color)
		{
			Vector3 from = (Vector2)start;
			foreach (Vector2Int point in path)
			{
				Vector3 to = (Vector2)point;
				Debug.DrawLine(from + Vector3.up * 0.2f, to + Vector3.up * 0.2f, color, 0.5f, false);
				from = to;
			}
		}
	}
}