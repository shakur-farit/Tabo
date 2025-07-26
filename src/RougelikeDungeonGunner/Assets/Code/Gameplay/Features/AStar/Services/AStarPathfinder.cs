using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	public class AStarPathfinder : IAStarPathfinder, IPathfinderInitializer
	{
		private HashSet<Vector2Int> _validPositions;

		public void Initialize(List<Vector2Int> validPositions) => 
			_validPositions = new HashSet<Vector2Int>(validPositions);

		public List<Vector2Int> FindPath(Vector2Int start, Vector2Int goal)
		{
			if (!_validPositions.Contains(start) || !_validPositions.Contains(goal))
				return null;

			var openSet = new PriorityQueue<Vector2Int>();
			var cameFrom = new Dictionary<Vector2Int, Vector2Int>();
			var gScore = new Dictionary<Vector2Int, float> { [start] = 0 };
			var fScore = new Dictionary<Vector2Int, float> { [start] = Heuristic(start, goal) };

			openSet.Enqueue(start, fScore[start]);
			var closedSet = new HashSet<Vector2Int>();

			while (openSet.Count > 0)
			{
				var current = openSet.Dequeue();

				if (current == goal)
					return ReconstructPath(cameFrom, current);

				closedSet.Add(current);

				foreach (var neighbor in GetNeighbors(current))
				{
					if (!_validPositions.Contains(neighbor) || closedSet.Contains(neighbor))
						continue;

					float tentativeG = gScore[current] + GetDistance(current, neighbor);

					if (!gScore.ContainsKey(neighbor) || tentativeG < gScore[neighbor])
					{
						cameFrom[neighbor] = current;
						gScore[neighbor] = tentativeG;
						float f = tentativeG + Heuristic(neighbor, goal);
						fScore[neighbor] = f;
						openSet.Enqueue(neighbor, f);
					}
				}
			}

			return null;
		}

		private float Heuristic(Vector2Int a, Vector2Int b) =>
				Vector2Int.Distance(a, b);

		private float GetDistance(Vector2Int a, Vector2Int b) =>
				(a.x != b.x && a.y != b.y) ? 1.414f : 1f;

		private IEnumerable<Vector2Int> GetNeighbors(Vector2Int pos)
		{
			Vector2Int[] directions =
			{
								Vector2Int.up,
								Vector2Int.down,
								Vector2Int.left,
								Vector2Int.right,
								new(1, 1),
								new(-1, 1),
								new(1, -1),
								new(-1, -1)
						};

			foreach (var dir in directions)
				yield return pos + dir;
		}

		private List<Vector2Int> ReconstructPath(Dictionary<Vector2Int, Vector2Int> cameFrom, Vector2Int current)
		{
			List<Vector2Int> path = new() { current };
			while (cameFrom.TryGetValue(current, out var prev))
			{
				path.Add(prev);
				current = prev;
			}
			path.Reverse();
			return path;
		}
	}
}