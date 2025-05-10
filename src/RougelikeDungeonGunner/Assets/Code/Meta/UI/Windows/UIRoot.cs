using UnityEngine;

namespace Code.Meta.UI.UIRoot.Factory
{
	public class UIRoot : MonoBehaviour
	{
		private void OnDestroy()
		{
			Debug.Log("Destroyed");
		}
	}
}