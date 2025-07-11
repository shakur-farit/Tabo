using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code.NodeGraph.Editor
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Room Node Graph", fileName = "RoomNodeGraph")]
	public class RoomNodeGraph : ScriptableObject
	{
		public List<RoomNode> RoomNodesList;
		public List<RoomNodeConfig> RoomNodeConfigList = new();
		public Dictionary<string, RoomNodeConfig> RoomNodeDictionary = new();
	}

	[Serializable]
	public class RoomNode
	{
		public RoomNodeTypeId TypeId;
		public bool DisplayInEditor;


		public void Setup(Rect rect, RoomNodeGraph currentNodeGraph, RoomNodeTypeId roomNodeType)
		{
			
		}
	}
}