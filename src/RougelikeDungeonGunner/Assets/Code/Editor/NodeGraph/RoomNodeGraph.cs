using System.Collections.Generic;
using UnityEngine;

namespace Code.NodeGraph.Editor
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Room Node Graph", fileName = "RoomNodeGraph")]
	public class RoomNodeGraph : ScriptableObject
	{
		public RoomNodeTypeList RoomNodeTypeList;
		public List<RoomNodeConfig> RoomNodeList = new();
		public Dictionary<string, RoomNodeConfig> RoomNodeDictionary = new();
	}
}