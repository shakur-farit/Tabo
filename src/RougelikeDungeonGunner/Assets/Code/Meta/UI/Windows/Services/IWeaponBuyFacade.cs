using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using UnityEngine;

namespace Code.Meta.UI.Windows.Behaviours
{
  public interface IWeaponBuyFacade
  {
    Sprite GetWeaponSprite();
    int GetWeaponPrice();
    void TryBuyWeapon();
    void RenderWeaponStats(WeaponStatsUIHolder holder);
    void CloseWindow();
  }
}