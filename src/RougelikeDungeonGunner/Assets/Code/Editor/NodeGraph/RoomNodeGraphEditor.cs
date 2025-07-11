using System;
using UnityEditor;
using UnityEditor.Callbacks;
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
		private static RoomNodeGraph _currentNodeGraph;

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

		[MenuItem("Room Node Graph Editor", menuItem = "Window/Dungeon Editor/Room Node Graph Editor")]
		private static void OpenWindow() => 
			GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");

		[OnOpenAsset(0)]
		public static bool IsDoubleClickAsset(int id, int line)
		{
			RoomNodeGraph roomNodeGraph = EditorUtility.InstanceIDToObject(id) as RoomNodeGraph;

			if(roomNodeGraph == null)
				return false;

			OpenWindow();

			_currentNodeGraph = roomNodeGraph;

			return true;
		}

		private void OnGUI()
		{
			if (_currentNodeGraph == null)
				return;

			ProcessEvents(Event.current);

			//DrawRoomNodes();

			if(GUI.changed)
				Repaint();
		}

		private void ProcessEvents(Event currentEvent) => 
			ProcessRoomNodeGraphEvents(currentEvent);

		private void ProcessRoomNodeGraphEvents(Event currentEvent)
		{
			switch (currentEvent.type)
			{
				case EventType.MouseDown:
					ProcessMouseDownEvent(currentEvent); 
					break;

				default:
					break;
			}
		}

		private void ProcessMouseDownEvent(Event currentEvent)
		{
			if (currentEvent.button == 1) 
				ShowContextMenu(currentEvent.mousePosition);
		}

		private void ShowContextMenu(Vector2 mousePosition)
		{
			GenericMenu menu = new GenericMenu();
			menu.AddItem(new GUIContent("Create Room Node"), false, CreateRoomNode, mousePosition);
			menu.ShowAsContext();
		}

		private void CreateRoomNode(object mousePositionObject) => 
			CreateRoomNode(mousePositionObject,  RoomNodeTypeId.Unknown);

		private void CreateRoomNode(object mousePositionObject, RoomNodeTypeId roomNodeType)
		{
			Vector2 mousePosition = (Vector2)mousePositionObject;

			RoomNode roomNode = new RoomNode();
			_currentNodeGraph.RoomNodesList.Add(roomNode);
			roomNode.Setup(new Rect(mousePosition, new Vector2(NodeWidth, NodeHeight)), _currentNodeGraph, roomNodeType);
		}
	}
}
