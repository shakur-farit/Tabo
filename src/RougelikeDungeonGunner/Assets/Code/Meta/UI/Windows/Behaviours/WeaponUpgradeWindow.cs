using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponUpgradeWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Transform _layout;

		private IWindowService _windowService;
    private IWeaponUpgradeShopItemsUIRenderer _renderer;

    [Inject]
		public void Constructor(IWindowService windowService, IWeaponUpgradeShopItemsUIRenderer renderer)
		{
			Id = WindowId.WeaponUpgradeWindow;

			_windowService = windowService;
      _renderer = renderer;
    }

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			RenderWeaponUpgradeShopItems();
		}

		private void RenderWeaponUpgradeShopItems() => 
      _renderer.RenderWeaponUpgradeShopItems(_layout);

    private void Close() => 
			_windowService.Close(WindowId.WeaponUpgradeWindow);
	}
}