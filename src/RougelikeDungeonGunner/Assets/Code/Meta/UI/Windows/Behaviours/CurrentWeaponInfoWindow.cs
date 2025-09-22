using Assets.Code.Gameplay.Features.Statuses;
using Assets.Code.Gameplay.Features.Weapon.Configs;
using Assets.Code.Gameplay.StaticData;
using Assets.Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Assets.Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using Assets.Code.Meta.UI.Windows.Service;
using Assets.Code.Progress.Provider;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.Code.Meta.UI.Windows.Behaviours
{
	public class CurrentWeaponInfoWindow : BaseWindow
	{
		[SerializeField] private WeaponStatsUIHolder _weaponStatsUIHolder; 
		[SerializeField] private EnchantsUIHolder _enchantsUIHolder;

		[SerializeField] private Image _weaponIcon;
		[SerializeField] private Button _closeButton;

		private WeaponConfig _weaponConfig;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(
			IWindowService windowService,
			IProgressProvider progressProvider,
			IStaticDataService staticDataService)
		{
			Id = WindowId.CurrentWeaponInfoWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
			_staticDataService = staticDataService;
		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			SetWeaponConfig();
			SetWeaponIcon();
			ShowStats();
			ShowEnchants();
		}

		private void SetWeaponIcon() => 
			_weaponIcon.sprite = _weaponConfig.Sprite;

		private void ShowStats()
		{
			foreach (WeaponStatUIEntry statUIEntry in _weaponConfig.StatsUIEntry)
				_weaponStatsUIHolder.CreateStatUIEntryItem(statUIEntry.StatUIEntryType, _weaponConfig);
		}

		private void ShowEnchants()
		{
			foreach (StatusSetup setup in  _weaponConfig.StatusSetups)
				_enchantsUIHolder.CreateEnchantUIEntryItem(setup);
		}

		private void Close() =>
			_windowService.Close(WindowId.CurrentWeaponInfoWindow);

		private void SetWeaponConfig() => 
			_weaponConfig = _staticDataService.GetWeaponConfig(_progressProvider.HeroData.CurrentWeaponTypeId);

	}
}