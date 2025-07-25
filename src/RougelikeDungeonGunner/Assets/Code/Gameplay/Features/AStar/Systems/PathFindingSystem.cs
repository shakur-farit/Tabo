using System.Collections.Generic;
using Assets.Code.Gameplay.Features.AStar;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class PathFindingSystem : IExecuteSystem
	{
		private Vector3 _lastHeroPositions;

		private readonly List<GameEntity> _buffer = new(32);

		private readonly IAStarPathfinding _pathfinding;
		private readonly IGroup<GameEntity> _chasers;
		private readonly IGroup<GameEntity> _heroes;
		private readonly IGroup<GameEntity> _pathfinders;

		public PathFindingSystem(GameContext game, IAStarPathfinding pathfinding)
		{
			_pathfinding = pathfinding;
			_chasers = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));

			_pathfinders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Pathfinder,
					GameMatcher.MinDistanceForRepath,
					GameMatcher.ValidPositions));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity pathfinder in _pathfinders)
			foreach (GameEntity chaser in _chasers.GetEntities(_buffer))
			{
				if (IsHeroChangePosition(_lastHeroPositions, hero.WorldPosition, pathfinder.MinDistanceForRepath))
				{
					Vector2Int chaserPosition = Vector2Int.FloorToInt(chaser.WorldPosition);
					Vector2Int heroPosition = Vector2Int.FloorToInt(hero.WorldPosition);

					List<Vector2Int> path = _pathfinding
						.FindPath(chaserPosition, heroPosition,new(pathfinder.ValidPositions));

					if (path == null)
						continue;

					chaser.ReplacePath(path);

					_lastHeroPositions = hero.WorldPosition;
				}
			}
		}

		private bool IsHeroChangePosition(Vector2 lastPosition, Vector2 currentPosition, float minDistance)
		{
			float distance = Vector2.Distance(lastPosition, currentPosition);

			return distance > minDistance;
		}
	}
}