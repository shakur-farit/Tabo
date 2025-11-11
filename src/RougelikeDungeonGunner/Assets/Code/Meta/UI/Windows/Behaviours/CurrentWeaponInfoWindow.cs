using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.CurrentWeaponInfo
{
	public class CurrentWeaponInfoWindow : BaseWindow
	{
		
		[SerializeField] private Button _closeButton;


		private IWindowService _windowService;

    [Inject]
		public void Constructor(IWindowService windowService)
		{
			Id = WindowId.CurrentWeaponInfoWindow;

			_windowService = windowService;
    }

		protected override void Initialize() => 
      _closeButton.onClick.AddListener(Close);

    private void Close() =>
			_windowService.Close(WindowId.CurrentWeaponInfoWindow);
  }
}