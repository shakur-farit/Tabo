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
		private readonly IGroup<GameEntity> _dungeons;

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
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity chaser in _chasers.GetEntities(_buffer))
			{
				if (_lastHeroPositions != hero.WorldPosition)
				{
					Debug.Log(_lastHeroPositions != hero.WorldPosition);
					Vector2Int chaserPosition = Vector2Int.FloorToInt(chaser.WorldPosition);
					Vector2Int heroPosition = Vector2Int.FloorToInt(hero.WorldPosition);


						List<Vector2Int> path = _pathfinding.FindPath(chaserPosition, heroPosition);

						Debug.Log($"path is null {path == null}");


						if (path == null)
						continue;

					chaser.ReplacePath(path);

					Debug.Log($"Path found {chaser.Path}");

					_lastHeroPositions = hero.WorldPosition;
				}
			}
		}
	}
}