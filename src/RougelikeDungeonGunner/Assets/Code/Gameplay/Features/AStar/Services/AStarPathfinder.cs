using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	public class AStarPathfinder : IAStarPathfinder, IPathfinderInitializer
	{
		private HashSet<Vector2Int> _validPositions;

		public void Initialize(List<Vector2Int> validPositions) => 
			_validPositions = new HashSet<Vector2Int>(validPositions);

		public List<Vector2Int> FindPath(Vector2 start, Vector2Int goal)
		{
			Vector2Int startPosition = FindBestStartNode(start, goal);
			Vector2Int goalPosition = _validPositions.Contains(goal)
				? goal
				: FindClosestValidPosition(goal);

			if (!_validPositions.Contains(startPosition) || !_validPositions.Contains(goalPosition))
				return null;

			PriorityQueue<Vector2Int> openSet = new();
			Dictionary<Vector2Int, Vector2Int> cameFrom = new();
			Dictionary<Vector2Int, float> gScore = new(){ [startPosition] = 0 };
			Dictionary<Vector2Int, float> fScore = new(){ [startPosition] = Heuristic(startPosition, goalPosition) };

			openSet.Enqueue(startPosition, fScore[startPosition]);
			HashSet<Vector2Int> closedSet = new();

			while (openSet.Count > 0)
			{
				Vector2Int current = openSet.Dequeue();

				if (current == goalPosition)
					return ReconstructPath(cameFrom, current);

				closedSet.Add(current);

				foreach (Vector2Int neighbor in GetNeighbors(current))
				{
					if (!_validPositions.Contains(neighbor) || closedSet.Contains(neighbor))
						continue;

					float tentativeG = gScore[current] + GetDistance(current, neighbor);

					if (!gScore.ContainsKey(neighbor) || tentativeG < gScore[neighbor])
					{
						cameFrom[neighbor] = current;
						gScore[neighbor] = tentativeG;
						float f = tentativeG + Heuristic(neighbor, goalPosition);
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

			foreach (Vector2Int dir in directions)
				yield return pos + dir;
		}

		private List<Vector2Int> ReconstructPath(Dictionary<Vector2Int, Vector2Int> cameFrom, Vector2Int current)
		{
			List<Vector2Int> path = new() { current };
			while (cameFrom.TryGetValue(current, out Vector2Int prev))
			{
				path.Add(prev);
				current = prev;
			}
			path.Reverse();
			return path;
		}

		private Vector2Int FindBestStartNode(Vector2 startPosition, Vector2Int goal)
		{
			Vector2Int baseNode = Vector2Int.FloorToInt(startPosition);

			List<Vector2Int> candidates = GetNeighbors(baseNode).Append(baseNode)
				.Where(pos => _validPositions.Contains(pos))
				.ToList();

			Vector2Int bestNode = baseNode;
			float bestDistance = float.MaxValue;

			foreach (Vector2Int node in candidates)
			{
				float dist = Vector2Int.Distance(node, goal);
				if (dist < bestDistance)
				{
					bestDistance = dist;
					bestNode = node;
				}
			}

			return bestNode;
		}

		private Vector2Int FindClosestValidPosition(Vector2Int target)
		{
			Vector2 targetWorld = (Vector2)target + new Vector2(0.5f, 0.5f);
			Vector2Int closest = target;
			float closestDistance = float.MaxValue;

			foreach (Vector2Int pos in _validPositions)
			{
				float dist = Vector2.Distance((Vector2)pos + new Vector2(0.5f, 0.5f), targetWorld);
				if (dist < closestDistance)
				{
					closestDistance = dist;
					closest = pos;
				}
			}

			return closest;
		}
	}
}