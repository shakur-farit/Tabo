using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Beahaviours;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Meta.Features.Shop.Upgrade.Factory;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class WeaponUpgradeShopItemsUIRenderer : IWeaponUpgradeShopItemsUIRenderer
  {
    private readonly ICurrentHeroWeaponProvider _heroWeapon;
    private readonly IStaticDataService _staticDataService;
    private readonly IWeaponUpgradeShopItemFactory _factory;

    public WeaponUpgradeShopItemsUIRenderer(
      ICurrentHeroWeaponProvider heroWeapon, 
      IStaticDataService staticDataService,
      IWeaponUpgradeShopItemFactory factory)
    {
      _heroWeapon = heroWeapon;
      _staticDataService = staticDataService;
      _factory = factory;
    }

    public void RenderWeaponUpgradeShopItems(Transform layout)
    {
      WeaponTypeId currentWeapon = _heroWeapon.CurrentWeaponTypeId;
      List<WeaponAvailableUpgrade> upgrades = _staticDataService.GetWeaponConfig(currentWeapon).AvailableUpgrades;

      foreach (WeaponAvailableUpgrade upgrade in upgrades)
      {
        WeaponUpgradeShopItem item = _factory.CreateUpgradeWeaponShopItem(upgrade.UpgradeType, layout);
        WeaponUpgradeShopItemConfig config = _staticDataService.GetWeaponUpgradeShopItemConfig(upgrade.UpgradeType);
        item.Setup(config);
      }
    }
  }
}