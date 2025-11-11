using Code.Meta.UI.GameLoading.Behaviours;
using Code.Meta.UI.GameLoading.Factory;
using UnityEngine;

namespace Code.Meta.UI.GameLoading.Services
{
	public class GameLoadingUIService : IGameLoadingUIService
	{
		private GameLoadingUI _gameLoadingUI;

		private readonly IGameLoadingUIFactory _factory;

		public GameLoadingUIService(IGameLoadingUIFactory factory) => 
			_factory = factory;

		public void Open()
    {
      _gameLoadingUI = _factory.CreateGameLoadingUI();
			Debug.Log("open");
    }

    public void Close()
    {
      Object.Destroy(_gameLoadingUI.gameObject);
      Debug.Log("close");

    }
  }
}