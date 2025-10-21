using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Weapon.Services
{
  public class CurrentAmmoCountProvider : ICurrentAmmoCountProvider
  {
    private WeaponTypeId _weaponTypeId = WeaponTypeId.Unknown;
    private int _currentAmmoCount;

    private readonly IStaticDataService _staticDataService;

    public CurrentAmmoCountProvider(IStaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
    }

    public int GetCurrentAmmoCount(WeaponTypeId typeId)
    {
      if (_weaponTypeId == typeId)
        return _currentAmmoCount;

      _weaponTypeId = typeId;
      WeaponConfig config = _staticDataService.GetWeaponConfig(typeId);
      return config.Stats.MaxAmmoCount;
    }

    public void SetCurrentAmmoCount(int currentAmmoCount) => 
      _currentAmmoCount = currentAmmoCount;

    public void Clean() => 
      _currentAmmoCount = 0;
  }
}