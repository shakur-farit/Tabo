using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	public interface IPathfinderInitializer
	{
		void Initialize(List<Vector2Int> validPositions);
	}
}