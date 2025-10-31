using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class CurrentWeaponInfoProvider : ICurrentWeaponInfoProvider
  {
    private readonly IStaticDataService _staticDataService;
    private readonly ICurrentHeroWeaponProvider _heroWeapon;

    public CurrentWeaponInfoProvider(IStaticDataService staticDataService, ICurrentHeroWeaponProvider heroWeapon)
    {
      _staticDataService = staticDataService;
      _heroWeapon = heroWeapon;
    }

    public WeaponConfig GetWeaponConfig() =>
      _staticDataService.GetWeaponConfig(_heroWeapon.CurrentWeaponTypeId);
  }
}