using NUnit.Framework;
using UnityEngine;

namespace Code.NodeGraph.Editor
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Room Node Type", fileName = "RoomNodeType")]
	public class RoomNodeType : ScriptableObject
	{
		public string RoomNodeTypeName;

		public bool DisplayInEditor = true;
		public bool IsCorridor;
		public bool IsCorridorNS;
		public bool IsCorridorEW;
		public bool IsEntrance;
		public bool IsBossRoom;
		public bool IsNone;
	}
}