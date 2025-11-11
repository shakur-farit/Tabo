using Code.Gameplay.StaticData;
using Code.Meta.Features.Information.EnchantInformation.Behaviours;
using Code.Meta.Features.Information.HeroInformation.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry.Services;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.CurrentWeaponEnchantInfo
{
	public class HeroInfoWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;

		private IWindowService _windowService;

		[Inject]
		public void Constructor(IWindowService windowService)
		{
			Id = WindowId.HeroInfoWindow;

			_windowService = windowService;
		}

		protected override void Initialize() =>
			_closeButton.onClick.AddListener(Close);

		private void Close() =>
			_windowService.Close(WindowId.HeroInfoWindow);
	}
}