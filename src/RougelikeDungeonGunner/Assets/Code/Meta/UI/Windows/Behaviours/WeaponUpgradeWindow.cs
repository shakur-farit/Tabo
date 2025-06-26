using System.Collections.Generic;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Factory;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponUpgradeWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Transform _layout;

		private IWindowService _windowService;
		private IWeaponUpgradeShopItemFactory _factory;
		private IProgressProvider _progressProvider;
		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(
			IWindowService windowService, 
			IWeaponUpgradeShopItemFactory factory, 
			IProgressProvider progressProvider,
			IStaticDataService staticDataService)
		{
			Id = WindowId.WeaponUpgradeWindow;

			_windowService = windowService;
			_factory = factory;
			_progressProvider = progressProvider;
			_staticDataService = staticDataService;
		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			CreateWeaponUpgradeShopItems();
		}

		private void CreateWeaponUpgradeShopItems()
		{
			WeaponTypeId currentWeapon = _progressProvider.HeroData.CurrentWeaponTypeId;
			List<WeaponAvailableUpgrades> upgrades = _staticDataService.GetWeaponConfig(currentWeapon).AvailableUpgrades;

			foreach (WeaponAvailableUpgrades upgrade in upgrades)
				_factory.CreateUpgradeWeaponShopItem(upgrade.UpgradeType, _layout);
		}

		private void Close() => 
			_windowService.Close(WindowId.WeaponUpgradeWindow);
	}
}