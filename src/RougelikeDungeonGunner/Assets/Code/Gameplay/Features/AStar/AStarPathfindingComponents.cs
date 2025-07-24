using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	[Game] public class Path : IComponent { public List<Vector2Int> Value; }
	[Game] public class PathfindingAvailable : IComponent { }
}