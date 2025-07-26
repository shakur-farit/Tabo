using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	[Game] public class Pathfinder : IComponent { }
	[Game] public class CurrentPath : IComponent { public List<Vector2Int> Value; }
	[Game] public class PendingPath : IComponent { public List<Vector2Int> Value; }
	[Game] public class MinDistanceForRepath : IComponent { public float Value; }
	[Game] public class PathfindingIntervalTimer : IComponent { public float Value; }
	[Game] public class PathfindingTimerLeft : IComponent { public float Value; }
	[Game] public class PathfindingTimerUp : IComponent { }
	[Game] public class PathfinderAvailable : IComponent { }
	[Game] public class PathfinderInitialized : IComponent { }
}