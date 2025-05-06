using UnityEngine;

namespace Code.Meta.UI.UIRoot.Factory
{
	public interface IWindowFactory
	{
		void SetUIRoot(RectTransform uiRoot);
		BaseWindow CreateWindow(WindowId windowId);
	}
}