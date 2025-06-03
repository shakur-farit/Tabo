using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
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

		[Inject]
		public void Constructor(
			IWindowService windowService, 
			IWeaponUpgradeShopItemFactory factory,
			IStaticDataService staticDataService)
		{
			Id = WindowId.WeaponUpgradeWindow;

			_windowService = windowService;
			_factory = factory;
			_staticDataService = staticDataService;
		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			CreateWeaponUpgradeShopItems();
		}

		private void CreateWeaponUpgradeShopItems()
		{
			IEnumerable<WeaponUpgradeShopItemConfig> configs = _staticDataService.GetAllWeaponUpgradeShopItemConfigs();

			foreach (WeaponUpgradeShopItemConfig config in configs)
			{
				WeaponUpgradeShopItem item = _factory.CreateUpgradeWeaponShopItem(config, _layout);
				item.Setup(config);
			}
		}

		private void Close() => 
			_windowService.Close(WindowId.WeaponUpgradeWindow);
	}
}