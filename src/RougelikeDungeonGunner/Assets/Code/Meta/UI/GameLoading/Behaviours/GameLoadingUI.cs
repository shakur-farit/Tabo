using UnityEngine;

namespace Code.Meta.UI.Windows
{
	public class GameLoadingUI : MonoBehaviour
	{
		private void Start()
		{
			transform.SetParent(null);
			DontDestroyOnLoad(gameObject);
		}
	}
}