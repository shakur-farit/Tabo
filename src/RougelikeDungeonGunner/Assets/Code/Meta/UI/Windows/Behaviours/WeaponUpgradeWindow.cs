using System.Collections.Generic;
using Assets.Code.Gameplay.Features.Weapon;
using Assets.Code.Gameplay.Features.Weapon.Configs;
using Assets.Code.Gameplay.StaticData;
using Assets.Code.Meta.Features.Shop.Upgrade.Factory;
using Assets.Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.Code.Meta.UI.Windows.Behaviours
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
			List<WeaponAvailableUpgrade> upgrades = _staticDataService.GetWeaponConfig(currentWeapon).AvailableUpgrades;

			foreach (WeaponAvailableUpgrade upgrade in upgrades)
				_factory.CreateUpgradeWeaponShopItem(upgrade.UpgradeType, _layout);
		}

		private void Close() => 
			_windowService.Close(WindowId.WeaponUpgradeWindow);
	}
}