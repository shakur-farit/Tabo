using System.Collections.Generic;
using UnityEngine;

namespace Code.Meta.UI.UIRoot.Factory
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Window Config", fileName = "WindowConfig")]
	public class WindowsConfig : ScriptableObject
	{
		public List<WindowConfig> WindowConfigs;
	}
}