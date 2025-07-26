using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	public interface IAStarPathfinder
	{
		List<Vector2Int> FindPath(Vector2Int start, Vector2Int goal);
	}
}