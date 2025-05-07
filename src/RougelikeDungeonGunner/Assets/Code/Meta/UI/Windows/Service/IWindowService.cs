namespace Code.Meta.UI.UIRoot.Factory
{
	public interface IWindowService
	{
		void Open(WindowId windowId);
		void Close(WindowId windowId);
	}
}