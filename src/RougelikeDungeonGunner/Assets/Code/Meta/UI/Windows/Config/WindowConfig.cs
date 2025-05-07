using UnityEngine;

namespace Code.Meta.UI.UIRoot.Factory
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Window Config", fileName = "WindowConfig")]
	public class WindowConfig : ScriptableObject
	{
		public WindowId TypeId;
		public GameObject ViewPrefab;
	}
}