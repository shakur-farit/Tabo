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

			_dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Dungeon,
					GameMatcher.ValidPositions));
		}

		public void Execute()
		{
			foreach (GameEntity dungeon in _dungeons)
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity chaser in _chasers.GetEntities(_buffer))
			{
				if (_lastHeroPositions != hero.WorldPosition)
				{
					_pathfinding.Initialize(dungeon.ValidPositions);

					List<Vector2> path = _pathfinding.FindPath(chaser.WorldPosition, hero.WorldPosition);

					chaser.ReplacePath(path);

					Debug.Log("Path found");

					_lastHeroPositions = hero.WorldPosition;
				}
			}
		}
	}
}