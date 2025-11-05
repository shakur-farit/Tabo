using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Weapon.Services;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class MobileHud : BaseWindow
	{
		[SerializeField] private Button _pauseButton;
		[SerializeField] private Button _reloadButton;

		private IWindowService _windowService;
		private ITimeService _time;
    private IWeaponReloadService _reloadService;

    [Inject]
		public void Constructor(IWindowService windowService, ITimeService time, IWeaponReloadService reloadService)
		{
			Id = WindowId.MobileHud;

			_windowService = windowService;
			_time = time;
      _reloadService = reloadService;
    }

		protected override void Initialize()
		{
			_pauseButton.onClick.AddListener(Pause);
			_reloadButton.onClick.AddListener(ReloadWeapon);
		}

		private void Pause()
		{
			_windowService.Open(WindowId.PauseWindow);

			_time.StopTime();
		}

    private void ReloadWeapon() => 
      _reloadService.StartReloading();
  }
}