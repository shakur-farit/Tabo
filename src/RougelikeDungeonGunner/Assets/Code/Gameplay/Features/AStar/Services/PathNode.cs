using UnityEngine;

namespace Assets.Code.Gameplay.Features.AStar
{
	public class PathNode
	{
		public readonly Vector2 Position;
		public float GCost;
		public float HCost;
		public PathNode Parent;

		public float FCost => GCost + HCost;

		public PathNode(Vector2 position) =>
			Position = position;
	}
}