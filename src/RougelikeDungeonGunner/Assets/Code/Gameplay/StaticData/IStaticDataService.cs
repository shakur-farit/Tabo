using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Ammo.Config;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
  public interface IStaticDataService
  {
    UniTask Load();
    AmmoConfig GetAmmoConfig(AmmoId ammoId);
    AmmoLevel GetAbilityLevel(AmmoId ammoId, int level);
    WeaponConfig GetWeaponConfig(WeaponId weaponId);
    WeaponLevel GetWeaponLevel(WeaponId weaponId, int level);
  }
}