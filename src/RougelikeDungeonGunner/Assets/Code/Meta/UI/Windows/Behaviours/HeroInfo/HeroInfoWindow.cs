using Code.Gameplay.Features.Weapon.Services;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.CurrentWeaponEnchantInfo
{
	public class HeroInfoWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Button _weaponInfoOpenButton;
		[SerializeField] private Image _weaponIcon;

		private IWindowService _windowService;
    private ICurrentWeaponInfoProvider _currentWeapon;

    [Inject]
		public void Constructor(IWindowService windowService, ICurrentWeaponInfoProvider currentWeapon)
		{
			Id = WindowId.HeroInfoWindow;

			_windowService = windowService;
      _currentWeapon = currentWeapon;
    }

		protected override void Initialize()
    {
      _weaponInfoOpenButton.onClick.AddListener(OpenCurrentWeaponInfoWindow);
      _closeButton.onClick.AddListener(Close);

      _weaponIcon.sprite = _currentWeapon.GetWeaponConfig().Sprite;
    }

    private void OpenCurrentWeaponInfoWindow() => 
      _windowService.Open(WindowId.CurrentWeaponInfoWindow);

    private void Close() =>
			_windowService.Close(WindowId.HeroInfoWindow);
	}
}