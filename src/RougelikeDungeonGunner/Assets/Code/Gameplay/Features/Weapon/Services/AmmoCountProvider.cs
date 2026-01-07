using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Services
{
  public class AmmoCountProvider : IAmmoCountProvider
  {

    private WeaponTypeId _weaponTypeId = WeaponTypeId.Unknown;
    private int _currentAmmoCount;

    public int GetCurrentAmmoCount(WeaponConfig config)
    {
      if (_weaponTypeId == config.TypeId)
        return _currentAmmoCount;

      _weaponTypeId = config.TypeId;

      return config.Stats.MaxAmmoCount;
    }

    public void SetCurrentAmmoCount(int currentAmmoCount) => 
      _currentAmmoCount = currentAmmoCount;

    public void Clean() =>
      _currentAmmoCount = 0;
  }
}