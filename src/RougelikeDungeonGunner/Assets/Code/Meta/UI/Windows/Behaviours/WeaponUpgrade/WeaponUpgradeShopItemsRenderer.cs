using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.WeaponUpgrade.Beahaviours;
using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using Code.Meta.Features.Shop.WeaponUpgrade.Factory;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.WeaponUpgrade
{
	public class WeaponUpgradeShopItemsRenderer : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private ICurrentHeroWeaponProvider _heroWeapon;
		private IStaticDataService _staticDataService;
		private IWeaponUpgradeShopItemFactory _factory;

		[Inject]
		public void Constructor(
			ICurrentHeroWeaponProvider heroWeapon,
			IStaticDataService staticDataService,
			IWeaponUpgradeShopItemFactory factory)
		{
			_heroWeapon = heroWeapon;
			_staticDataService = staticDataService;
			_factory = factory;
		}

		private void Start() => 
			RenderWeaponUpgradeShopItems();

		public void RenderWeaponUpgradeShopItems()
		{
			WeaponTypeId currentWeapon = _heroWeapon.CurrentWeaponTypeId;
			List<WeaponAvailableUpgrade> upgrades = _staticDataService.GetWeaponConfig(currentWeapon).AvailableUpgrades;

			foreach (WeaponAvailableUpgrade upgrade in upgrades)
			{
				WeaponUpgradeShopItem item = _factory.CreateUpgradeWeaponShopItem(upgrade.UpgradeType, _holder);
				WeaponUpgradeShopItemConfig config = _staticDataService.GetWeaponUpgradeShopItemConfig(upgrade.UpgradeType);
				item.Setup(config);
			}
		}
	}
}