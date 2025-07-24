using Code.Progress.Data.Transient;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Code.Gameplay.Features.AStar
{
	public class AStarPathfinding : IAStarPathfinding
	{
		private  HashSet<Vector2Int> _validPositions;

		public void Initialize(List<Vector2Int> validPositions, float tileSize = 1) => 
			_validPositions = new HashSet<Vector2Int>(validPositions);

		public List<Vector2Int> FindPath(Vector2Int start, Vector2Int goal)
		{
			HashSet<Vector2Int> openSet = new() { start };
			HashSet<Vector2Int> closedSet = new();
			Dictionary<Vector2Int, Vector2Int> cameFrom = new();
			Dictionary<Vector2Int, float> gScore = new() { [start] = 0 };
			Dictionary<Vector2Int, float> fScore = new() { [start] = Heuristic(start, goal) };

			while (openSet.Count > 0)
			{
				Vector2Int current = openSet.OrderBy(n => fScore.GetValueOrDefault(n, float.MaxValue)).First();

				if (current == goal)
					return ReconstructPath(cameFrom, current);

				openSet.Remove(current);
				closedSet.Add(current);

				foreach (Vector2Int neighbor in GetNeighbors(current))
				{
					if (!_validPositions.Contains(neighbor) || closedSet.Contains(neighbor))
						continue;

					float tentativeG = gScore[current] + GetDistance(current, neighbor);

					if (tentativeG < gScore.GetValueOrDefault(neighbor, float.MaxValue))
					{
						cameFrom[neighbor] = current;
						gScore[neighbor] = tentativeG;
						fScore[neighbor] = tentativeG + Heuristic(neighbor, goal);
						openSet.Add(neighbor);
					}
				}
			}

			return null;
		}

		private IEnumerable<Vector2Int> GetNeighbors(Vector2Int pos)
		{
			Vector2Int[] dirs = {
			Vector2Int.up, Vector2Int.down,
			Vector2Int.left, Vector2Int.right,
			new(1, 1), new(1, -1), new(-1, 1), new(-1, -1)
		};

			foreach (var dir in dirs)
			{
				yield return pos + dir;
			}
		}

		private float Heuristic(Vector2Int a, Vector2Int b) =>
			Vector2Int.Distance(a, b);

		private float GetDistance(Vector2Int a, Vector2Int b) =>
			(a.x != b.x && a.y != b.y) ? 1.414f : 1f;

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
