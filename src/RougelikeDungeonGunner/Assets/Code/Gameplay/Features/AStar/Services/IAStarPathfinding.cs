using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	public interface IAStarPathfinding
	{
		void Initialize(List<Vector2Int> validPositions, float tileSize = 1f);
		List<Vector2Int> FindPath(Vector2Int start, Vector2Int goal);
	}
}