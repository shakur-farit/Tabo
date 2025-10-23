using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Meta.UI.Windows.Behaviours
{
  public interface ICurrentWeaponInfoProvider
  {
    WeaponConfig GetWeaponConfig();
  }
}