using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using UnityEngine.UI;

namespace Code.Meta.UI.Windows.Behaviours
{
  public interface IWeaponInfoUIRenderer
  {
    void RenderInfoUI(WeaponStatsUIHolder statsHolder, EnchantsUIHolder enchantsHolder, Image icon);
  }
}