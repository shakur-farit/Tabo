namespace Code.Gameplay.Features.Weapon.Services
{
  public interface ICurrentAmmoCountProvider
  {
    int GetCurrentAmmoCount(WeaponTypeId typeId);
    void SetCurrentAmmoCount(int currentAmmoCount);
    void Clean();
  }
}