namespace Code.Gameplay.Features.Weapon.Services
{
  public interface IWeaponReloadService
  {
    bool IsReloading { get; }
    void StopReloading();
    void StartReloading();
  }
}