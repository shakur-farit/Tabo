namespace Code.Gameplay.Features.Weapon.Systems
{
  public interface IWeaponReloadService
  {
    bool IsReloading { get; }
    void StopReloading();
    void StartReloading();
  }
}