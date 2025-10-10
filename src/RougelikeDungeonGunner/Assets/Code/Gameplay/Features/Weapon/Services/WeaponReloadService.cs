namespace Code.Gameplay.Features.Weapon.Services
{
  public class WeaponReloadService : IWeaponReloadService
  {
    public bool IsReloading { get; private set; }

    public void StartReloading() =>
      IsReloading = true;

    public void StopReloading() => 
      IsReloading = false;
  }
}