using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.EnchantUIEntry;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
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
		private IProgressProvider _progressProvider;
		private IStaticDataService _staticDataService;
    private ISelectedEnchantUIEntryProvider _enchantUIEntry;

    [Inject]
		public void Constructor(
			IWindowService windowService,
			IProgressProvider progressProvider,
			ISelectedEnchantUIEntryProvider enchantUIEntry,
			IStaticDataService staticDataService)
		{
			Id = WindowId.EnchantStatsWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
			_staticDataService = staticDataService;
      _enchantUIEntry = enchantUIEntry;
    }

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			ShowStats();
		}

		private void ShowStats()
		{
			EnchantUIEntryConfig config =
				_staticDataService.GetEnchantUIEntryItemConfig(_enchantUIEntry.TypeId);

			foreach (EnchantStatUIEntry statUIEntry in config.EnchantStatUIEntries)
				_holder.CreateStats(statUIEntry.TypeId);
		}

		private void Close() =>
			_windowService.Close(WindowId.EnchantStatsWindow);
	}
}