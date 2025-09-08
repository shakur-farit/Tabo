#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Code.Editor.Tools
{
	public class MousePositionViewer : EditorWindow
	{
		private Vector3 _capturedPosition;
		private bool _hasCaptured;

		[MenuItem("Tools/Mouse Position Viewer")]
		public static void ShowWindow()
		{
			GetWindow<MousePositionViewer>("Mouse Position Viewer");
		}

		private void OnEnable() => 
			SceneView.duringSceneGui += OnSceneGUI;

		private void OnDisable() => 
			SceneView.duringSceneGui -= OnSceneGUI;

		private void OnGUI()
		{
			EditorGUILayout.LabelField("Click in Scene View to capture position", EditorStyles.boldLabel);

			if (_hasCaptured)
			{
				EditorGUILayout.Space();

				DrawCoordinateField("X", _capturedPosition.x);
				DrawCoordinateField("Y", _capturedPosition.y);
				DrawCoordinateField("Z", _capturedPosition.z);
			}
			else
			{
				EditorGUILayout.HelpBox("No position captured yet.", MessageType.Info);
			}
		}

		private void DrawCoordinateField(string label, float value)
		{
			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.FloatField(label, value);

			if (GUILayout.Button("Copy", GUILayout.Width(50))) 
				EditorGUIUtility.systemCopyBuffer = value.ToString("F2");

			EditorGUILayout.EndHorizontal();
		}

		private void OnSceneGUI(SceneView sceneView)
		{
			Event e = Event.current;

			if (e.type == EventType.MouseDown && e.button == 0)
			{
				Ray ray = HandleUtility.GUIPointToWorldRay(e.mousePosition);
				Plane plane = new Plane(Vector3.forward, Vector3.zero);

				if (plane.Raycast(ray, out float distance))
				{
					_capturedPosition = ray.GetPoint(distance);
					_hasCaptured = true;
					Repaint();
					e.Use();
				}
			}
		}
	}
}
#endif