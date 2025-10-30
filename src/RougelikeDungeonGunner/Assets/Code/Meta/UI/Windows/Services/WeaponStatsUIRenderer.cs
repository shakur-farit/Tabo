using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class WeaponStatsUIRenderer : IWeaponStatsUIRenderer
  {
    private readonly IStaticDataService _staticDataService;
    private readonly IWeaponShopService _shopService;

    public WeaponStatsUIRenderer(IStaticDataService staticDataService, IWeaponShopService shopService)
    {
      _staticDataService = staticDataService;
      _shopService = shopService;
    }

    public void RenderUIStats(WeaponStatsUIHolder holder)
    {
      WeaponConfig weaponConfig =
        _staticDataService
          .GetWeaponConfig(_shopService.WeaponTypeId);

      foreach (WeaponStatUIEntry uiEntry in weaponConfig.StatsUIEntry)
        holder.CreateStatUIEntryItem(uiEntry.StatUIEntryType, weaponConfig);
    }
  }
}