using NUnit.Framework;
using UnityEngine;

namespace Code.NodeGraph.Editor
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Room Node", fileName = "RoomNode")]
	public class RoomNode : ScriptableObject
	{
		public RoomNodeTypeId TypeId;

		public bool DisplayInEditor = true;
	}
}