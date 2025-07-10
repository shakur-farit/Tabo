using System.Collections.Generic;
using UnityEngine;

namespace Code.NodeGraph.Editor
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Room Node Type List", fileName = "RoomNodeTypeList")]
	public class RoomNodeTypeList : ScriptableObject
	{
		public List<RoomNodeType> TypeList;
	}
}