using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.NodeGraph.Editor
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Room Node Graph", fileName = "RoomNodeGraph")]
	public class RoomNodeGraph : ScriptableObject
	{
		[FormerlySerializedAs("RoomNodeTypeList")] public RoomNodeList roomNodeList;
		public List<RoomNodeConfig> RoomNodeList = new();
		public Dictionary<string, RoomNodeConfig> RoomNodeDictionary = new();
	}
}