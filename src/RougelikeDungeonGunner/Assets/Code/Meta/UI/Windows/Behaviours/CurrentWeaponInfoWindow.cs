using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class CurrentWeaponInfoWindow : BaseWindow
	{
		[SerializeField] private Transform _statsHolder;
		[SerializeField] private Transform _enchantsHolder;
		[SerializeField] private Image _weaponIcon;
		[SerializeField] private Button _closeButton;

		private WeaponConfig _weaponConfig;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private IWeaponStatUIEntryItemFactory _statUIEntryItemFactory;
		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(
			IWindowService windowService,
			IProgressProvider progressProvider,
			IStaticDataService staticDataService,
			IWeaponStatUIEntryItemFactory statUIEntryItemFactory)
		{
			Id = WindowId.CurrentWeaponInfoWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
			_staticDataService = staticDataService;
			_statUIEntryItemFactory = statUIEntryItemFactory;
		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			SetWeaponConfig();
			SetWeaponIcon();
			ShowStats();
		}

		private void SetWeaponIcon() => 
			_weaponIcon.sprite = _weaponConfig.Sprite;

		private void ShowStats()
		{
			foreach (WeaponStatUIEntry statUIEntry in _weaponConfig.StatsUIEntry)
				_statUIEntryItemFactory.CreateStatUIEntryItem(statUIEntry.StatUIEntryType, _statsHolder, _weaponConfig);
		}

		private void Close() =>
			_windowService.Close(WindowId.CurrentWeaponInfoWindow);

		private void SetWeaponConfig() => 
			_weaponConfig= _staticDataService.GetWeaponConfig(_progressProvider.HeroData.CurrentWeaponTypeId);
	}
}