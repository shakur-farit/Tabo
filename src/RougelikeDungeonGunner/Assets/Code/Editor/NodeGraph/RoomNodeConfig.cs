using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.NodeGraph.Editor
{
	public class RoomNodeConfig : ScriptableObject
	{
		public string Id;
		public List<string> ParentRoomNodeIdList = new();
		public List<string> ChildRoomNodeIdList = new();
		public RoomNodeGraph RoomNodeGraph;
		[FormerlySerializedAs("RoomNodeType")] public RoomNode roomNode;
		[FormerlySerializedAs("RoomNodeTypeList")] public RoomNodeList roomNodeList;
	}
}