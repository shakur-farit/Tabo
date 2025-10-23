using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class CurrentWeaponInfoWindow : BaseWindow
	{
		[SerializeField] private WeaponStatsUIHolder _weaponStatsUIHolder; 
		[SerializeField] private EnchantsUIHolder _enchantsUIHolder;
    [SerializeField] private Image _weaponIcon;
		[SerializeField] private Button _closeButton;


		private IWindowService _windowService;
    private IWeaponInfoUIRenderer _uiRenderer;

    [Inject]
		public void Constructor(IWindowService windowService, IWeaponInfoUIRenderer uiRenderer)
		{
			Id = WindowId.CurrentWeaponInfoWindow;

			_windowService = windowService;
      _uiRenderer = uiRenderer;
    }

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			RenderUI();
		}

    private void RenderUI() => 
      _uiRenderer.RenderInfoUI(_weaponStatsUIHolder, _enchantsUIHolder, _weaponIcon);

    private void Close() =>
			_windowService.Close(WindowId.CurrentWeaponInfoWindow);
  }
}