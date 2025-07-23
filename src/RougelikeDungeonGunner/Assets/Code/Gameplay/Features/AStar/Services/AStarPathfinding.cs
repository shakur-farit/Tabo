using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	public class AStarPathfinding : IAStarPathfinding
	{
		private HashSet<Vector2> _validPositions;
		private float _tileSize;

		public void Initialize(List<Vector2> validPositions, float tileSize = 1f)
		{
			_validPositions = new HashSet<Vector2>(validPositions);
			_tileSize = tileSize;
		}

		public List<Vector2> FindPath(Vector2 start, Vector2 goal)
		{
			List<PathNode> openSet = new List<PathNode>();
			HashSet<Vector2> closedSet = new HashSet<Vector2>();

			PathNode startNode = new(start) { HCost = Heuristic(start, goal) };
			openSet.Add(startNode);

			while (openSet.Count > 0)
			{
				PathNode current = openSet.OrderBy(n => n.FCost).First();

				if (Vector2.Distance(current.Position, goal) < _tileSize * 0.5f)
					return ReconstructPath(current);

				openSet.Remove(current);
				closedSet.Add(current.Position);

				foreach (Vector2 neighborPos in GetNeighbors(current.Position))
				{
					if (closedSet.Contains(neighborPos))
						continue;

					float tentativeG = current.GCost + Vector2.Distance(current.Position, neighborPos);

					PathNode neighbor = openSet.FirstOrDefault(n => n.Position == neighborPos);
					if (neighbor == null)
					{
						neighbor = new PathNode(neighborPos)
						{
							GCost = tentativeG,
							HCost = Heuristic(neighborPos, goal),
							Parent = current
						};
						openSet.Add(neighbor);
					}
					else if (tentativeG < neighbor.GCost)
					{
						neighbor.GCost = tentativeG;
						neighbor.Parent = current;
					}
				}
			}

			return null;
		}

		private float Heuristic(Vector2 a, Vector2 b) =>
				Vector2.Distance(a, b);

		private List<Vector2> GetNeighbors(Vector2 position)
		{
			List<Vector2> neighbors = new();
			Vector2[] directions =
			{
								Vector2.up,
								Vector2.down,
								Vector2.left,
								Vector2.right,
								new(1, 1),    
								new(-1, 1),   
								new(1, -1), 
								new(-1, -1),
						};

			foreach (Vector2 dir in directions)
			{
				Vector2 neighbor = position + dir * _tileSize;
				if (_validPositions.Contains(neighbor))
					neighbors.Add(neighbor);
			}

			return neighbors;
		}

		private List<Vector2> ReconstructPath(PathNode node)
		{
			List<Vector2> path = new List<Vector2>();
			while (node != null)
			{
				path.Add(node.Position);
				node = node.Parent;
			}

			path.Reverse();
			return path;
		}
	}
}
