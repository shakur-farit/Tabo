using System.Collections.Generic;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
  public interface IWeaponShopUpdater
  {
    void UpdateWeaponsInShop(List<GameObject> items, Transform layout);
  }
}