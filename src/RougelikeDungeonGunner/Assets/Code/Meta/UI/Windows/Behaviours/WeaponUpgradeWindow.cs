using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Beahaviours;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Meta.Features.Shop.Upgrade.Factory;
using Code.Meta.UI.Windows.Service;
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
		private IStaticDataService _staticDataService;
		private ICurrentHeroWeaponProvider _heroWeapon;

		[Inject]
		public void Constructor(
			IWindowService windowService, 
			IWeaponUpgradeShopItemFactory factory, 
			ICurrentHeroWeaponProvider heroWeapon,
			IStaticDataService staticDataService)
		{
			Id = WindowId.WeaponUpgradeWindow;

			_windowService = windowService;
			_factory = factory;
			_staticDataService = staticDataService;
			_heroWeapon = heroWeapon;
		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			CreateWeaponUpgradeShopItems();
		}

		private void CreateWeaponUpgradeShopItems()
		{
			WeaponTypeId currentWeapon = _heroWeapon.CurrentWeaponTypeId;
			List<WeaponAvailableUpgrade> upgrades = _staticDataService.GetWeaponConfig(currentWeapon).AvailableUpgrades;

			foreach (WeaponAvailableUpgrade upgrade in upgrades)
			{
				WeaponUpgradeShopItem item = _factory.CreateUpgradeWeaponShopItem(upgrade.UpgradeType, _layout);
				WeaponUpgradeShopItemConfig config = _staticDataService.GetWeaponUpgradeShopItemConfig(upgrade.UpgradeType);
				item.Setup(config);
			}
		}

		private void Close() => 
			_windowService.Close(WindowId.WeaponUpgradeWindow);
	}
}