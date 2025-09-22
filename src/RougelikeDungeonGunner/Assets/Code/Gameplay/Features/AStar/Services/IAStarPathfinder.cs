using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar.Services
{
	public interface IAStarPathfinder
	{
		List<Vector2Int> FindPath(Vector2 start, Vector2Int goalPosition);
	}
}