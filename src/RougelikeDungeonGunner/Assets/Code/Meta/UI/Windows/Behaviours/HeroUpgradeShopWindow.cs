using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class HeroUpgradeShopWindow : BaseWindow
	{
		[SerializeField] private Transform _holder;
		[SerializeField] private Button _closeButton;

		private IWindowService _windowService;
		private IHeroUpgradeShopItemRenderer _renderer;

		[Inject]
		public void Constructor(IWindowService windowService, IHeroUpgradeShopItemRenderer renderer)
		{
			Id = WindowId.HeroUpgradeShopWindow;

			_windowService = windowService;
			_renderer = renderer;
		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			ShowEnchants();
		}

		private void Close() =>
			_windowService.Close(WindowId.HeroUpgradeShopWindow);

		private void ShowEnchants() => 
			_renderer.RenderItems(_holder);
	}
}