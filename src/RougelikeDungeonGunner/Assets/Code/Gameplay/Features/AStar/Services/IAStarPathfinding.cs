using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	public interface IAStarPathfinding
	{
		void Initialize(List<Vector2> validPositions, float tileSize = 1f);
		List<Vector2> FindPath(Vector2 start, Vector2 goal);
	}
}