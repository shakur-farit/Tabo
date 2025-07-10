using System;
using UnityEditor;
using UnityEngine;

namespace Code.NodeGraph.Editor
{
	public class RoomNodeGraphEditor : EditorWindow
	{
		private const float NodeWidth = 160f;
		private const float NodeHeight = 75f;
		private const int NodePadding = 25;
		private const int NodeBorder = 12;

		private GUIStyle _roomNodeStyle;

		[MenuItem("Room Node Graph Editor", menuItem = "Window/Dungeon Editor/Room Node Graph Editor")]
		private static void OpenWindow() => 
			GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");

		private void OnEnable()
		{
			_roomNodeStyle = new GUIStyle
			{
				normal =
				{
					background = EditorGUIUtility.Load("node1") as Texture2D,
					textColor = Color.white
				},
				padding = new RectOffset(NodePadding, NodePadding, NodePadding, NodePadding)
			};

			_roomNodeStyle.padding = new RectOffset(NodeBorder, NodeBorder, NodeBorder, NodeBorder);
		}

		private void OnGUI()
		{
			GUILayout.BeginArea(new Rect(new Vector2(100f, 100f), new Vector2(NodeWidth, NodeHeight)), _roomNodeStyle);
			EditorGUILayout.LabelField("Node 1");
			GUILayout.EndArea();
		}
	}
}
