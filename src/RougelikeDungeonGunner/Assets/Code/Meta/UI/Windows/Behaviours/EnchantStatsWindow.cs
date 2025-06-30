using Code.Gameplay.Common;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Configs;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.WSA;
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
		private IWeaponEnchantStatUIEntryFactory _factory;

		[Inject]
		public void Constructor(
			IWindowService windowService,
			IProgressProvider progressProvider,
			IStaticDataService staticDataService,
			IWeaponEnchantStatUIEntryFactory factory)
		{
			Id = WindowId.EnchantStatsWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
			_staticDataService = staticDataService;
			_factory = factory;
		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			ShowStats();
		}

		private void ShowStats()
		{
			WeaponEnchantUIEntryConfig config =
				_staticDataService.GetWeaponEnchantUIEntryItemConfig(_progressProvider.WeaponData.SelectedEnchantUITypeId);

			foreach (EnchantStatUIEntry statUIEntry in config.EnchantStatUIEntries)
				_holder.CreateStats(statUIEntry.TypeId);
		}

		private void Close() =>
			_windowService.Close(WindowId.EnchantStatsWindow);
	}
}