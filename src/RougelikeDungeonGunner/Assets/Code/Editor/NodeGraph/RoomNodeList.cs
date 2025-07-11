using System.Collections.Generic;
using UnityEngine;

namespace Code.NodeGraph.Editor
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Room Node List", fileName = "RoomNodeList")]
	public class RoomNodeList : ScriptableObject
	{
		public List<RoomNode> RoomNodesList;
	}
}