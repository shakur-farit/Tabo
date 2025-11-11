using UnityEngine;

namespace Code.Meta.UI.GameLoading.Behaviours
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