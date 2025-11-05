using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Gameplay.Features.Weapon.Services
{
  public interface ICurrentWeaponInfoProvider
  {
    WeaponConfig GetWeaponConfig();
  }
}