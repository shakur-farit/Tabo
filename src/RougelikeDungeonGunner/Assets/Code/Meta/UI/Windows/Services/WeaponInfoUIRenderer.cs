using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.Features.Weapon.Services;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using UnityEngine.UI;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class WeaponInfoUIRenderer : IWeaponInfoUIRenderer
  {
    private readonly IWeaponStatusSetupProvider _statusSetupProvider;
    private readonly ICurrentWeaponInfoProvider _currentWeapon;

    public WeaponInfoUIRenderer(IWeaponStatusSetupProvider statusSetupProvider, ICurrentWeaponInfoProvider currentWeapon)
    {
      _statusSetupProvider = statusSetupProvider;
      _currentWeapon = currentWeapon;
    }

    public void RenderInfoUI(WeaponStatsUIHolder statsHolder, EnchantsUIHolder enchantsHolder, Image icon)
    {
      SetSprite(icon);
      ShowEnchants(enchantsHolder);
      ShowStats(statsHolder);
    }

    private void SetSprite(Image icon) =>
      icon.sprite = _currentWeapon.GetWeaponConfig().Sprite;

    private void ShowStats(WeaponStatsUIHolder holder)
    {
      WeaponConfig config = _currentWeapon.GetWeaponConfig();

      foreach (WeaponStatUIEntry statUIEntry in config.StatsUIEntry)
        holder.CreateStatUIEntryItem(statUIEntry.StatUIEntryType, config);
    }

    private void ShowEnchants(EnchantsUIHolder holder)
    {
      foreach (StatusSetup setup in _statusSetupProvider.GetStatusSetups(_currentWeapon.GetWeaponConfig().TypeId))
        holder.CreateEnchantUIEntryItem(setup);
    }
  }
}