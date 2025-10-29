using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Gameplay.Features.Weapon.Services
{
  public interface IAmmoCountProvider
  {
    int GetCurrentAmmoCount(WeaponConfig config);
    void SetCurrentAmmoCount(int currentAmmoCount);
    void Clean();
  }
}