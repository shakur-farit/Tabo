using System.Collections.Generic;
using UnityEngine;

namespace Code.NodeGraph.Editor
{
	public class RoomNodeConfig : ScriptableObject
	{
		public string Id;
		public List<string> ParentRoomNodeIdList = new();
		public List<string> ChildRoomNodeIdList = new();
		public RoomNodeGraph RoomNodeGraph;
		public RoomNodeType RoomNodeType;
		public RoomNodeTypeList RoomNodeTypeList;
	}
}