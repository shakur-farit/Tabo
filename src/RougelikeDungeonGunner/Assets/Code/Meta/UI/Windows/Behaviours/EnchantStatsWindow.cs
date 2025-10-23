using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class EnchantStatsWindow : BaseWindow
	{
		[SerializeField] private EnchantStatsUIHolder _holder;
		[SerializeField] private Button _closeButton;

		private IWindowService _windowService;
    private IEnchantStatsUIRenderer _statsUIRenderer;


    [Inject]
		public void Constructor(IWindowService windowService, IEnchantStatsUIRenderer statsUIRenderer)
		{
			Id = WindowId.EnchantStatsWindow;

			_windowService = windowService;
      _statsUIRenderer = statsUIRenderer;
    }

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			ShowStats();
		}

		private void ShowStats() => 
      _statsUIRenderer.RenderUIStats(_holder);

    private void Close() =>
			_windowService.Close(WindowId.EnchantStatsWindow);
	}
}