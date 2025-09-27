using Code.Gameplay.Common.Time;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class Hud : BaseWindow
	{
		[SerializeField] private Button _pauseButton;

		private IWindowService _windowService;
		private ITimeService _time;

		[Inject]
		public void Constructor(IWindowService windowService, ITimeService time)
		{
			Id = WindowId.Hud;

			_windowService = windowService;
			_time = time;
		}

		protected override void Initialize()
		{
			_pauseButton.onClick.AddListener(Pause);
		}

		private void Pause()
		{
			_windowService.Open(WindowId.PauseWindow);

			_time.StopTime();
		}
	}
}