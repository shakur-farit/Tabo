using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class CurrentWeaponInfoWindow : BaseWindow
	{
		[SerializeField] private WeaponStatsUIHolder _weaponStatsUIHolder; 
		[SerializeField] private EnchantsUIHolder _enchantsUIHolder;

		[SerializeField] private Image _weaponIcon;
		[SerializeField] private Button _closeButton;

		private WeaponConfig _weaponConfig;

		private IWindowService _windowService;
		private IStaticDataService _staticDataService;
		private ICurrentHeroWeaponProvider _heroWeapon;
    private IWeaponStatusSetupProvider _statusSetupProvider;

    [Inject]
		public void Constructor(
			IWindowService windowService,
			ICurrentHeroWeaponProvider heroWeapon,
			IWeaponStatusSetupProvider statusSetupProvider,
			IStaticDataService staticDataService)
		{
			Id = WindowId.CurrentWeaponInfoWindow;

			_windowService = windowService;
			_staticDataService = staticDataService;
			_heroWeapon = heroWeapon;
      _statusSetupProvider = statusSetupProvider;
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
			foreach (StatusSetup setup in  _statusSetupProvider.GetStatusSetups(_weaponConfig.TypeId))
				_enchantsUIHolder.CreateEnchantUIEntryItem(setup);
		}

		private void Close() =>
			_windowService.Close(WindowId.CurrentWeaponInfoWindow);

		private void SetWeaponConfig() => 
			_weaponConfig = _staticDataService.GetWeaponConfig(_heroWeapon.CurrentWeaponTypeId);

	}
}