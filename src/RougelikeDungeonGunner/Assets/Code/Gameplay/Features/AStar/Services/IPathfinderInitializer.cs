using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.AStar.Services
{
	public interface IPathfinderInitializer
	{
		void Initialize(List<Vector2Int> validPositions);
	}
}