using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class EnchantShopWindow : BaseWindow
	{
		[SerializeField] private Transform _holder;
		[SerializeField] private Button _closeButton;

		private IWindowService _windowService;
    private IEnchantShopItemRenderer _itemRenderer;

    [Inject]
		public void Constructor(IWindowService windowService, IEnchantShopItemRenderer itemRenderer)
		{
			Id = WindowId.EnchantShopWindow;

			_windowService = windowService;
      _itemRenderer = itemRenderer;
    }

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			ShowEnchants();
		}

		private void Close() =>
			_windowService.Close(WindowId.EnchantShopWindow);

		private void ShowEnchants() => 
      _itemRenderer.RenderItems(_holder);
  }
}