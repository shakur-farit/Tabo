using System.Collections.Generic;
using Code.Common.Utilities;
using Code.Gameplay.Features.Hero.Services;
using Code.Meta.Features.Shop.Weapon;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.Weapon.Factory;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class WeaponShopUpdater : IWeaponShopUpdater
  {
    private readonly IWeaponShopItemFactory _factory;
    private readonly ICurrentHeroWeaponProvider _heroWeapon;

    public WeaponShopUpdater(IWeaponShopItemFactory factory, ICurrentHeroWeaponProvider heroWeapon)
    {
      _factory = factory;
      _heroWeapon = heroWeapon;
    }

    public void UpdateWeaponsInShop(List<GameObject> items, Transform layout)
    {
      Clear(items);

      List<WeaponShopItemTypeId> ids = EnumUtility.InitEnumList<WeaponShopItemTypeId>();

      foreach (WeaponShopItemTypeId id in ids)
      {
        WeaponShopItem item = _factory.CreateWeaponShopItem(id, layout);

        if (item.WeaponToBuy == _heroWeapon.CurrentWeaponTypeId)
          Object.Destroy(item.gameObject);
        else
          items.Add(item.gameObject);
      }
    }

    private void Clear(List<GameObject> items)
    {
      foreach (GameObject item in items)
        Object.Destroy(item);

      items.Clear();
    }
  }
}