using UnityEngine;

namespace Code.Meta.UI.Windows
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Game Loading UI Config", fileName = "GameLoadingUIConfig")]
	public class GameLoadingUIConfig : ScriptableObject
	{
		public GameObject ViewPrefab;
	}
}