using UnityEngine;

namespace Code.Meta.UI.Windows
{
	public class GameLoadingUIService : IGameLoadingUIService
	{
		private GameLoadingUI _gameLoadingUI;

		private readonly IGameLoadingUIFactory _factory;

		public GameLoadingUIService(IGameLoadingUIFactory factory) => 
			_factory = factory;

		public void Open() => 
			_gameLoadingUI = _factory.CreateGameLoadingUI();

		public void Close() =>
			Object.Destroy(_gameLoadingUI.gameObject);
	}
}