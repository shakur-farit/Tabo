using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Ammo.Config;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
  public interface IStaticDataService
  {
    UniTask Load();
    AmmoConfig GetAmmoConfig(AmmoId ammoId);
    AmmoLevel GetAmmoLevel(AmmoId ammoId, int level);
    WeaponConfig GetWeaponConfig(WeaponTypeId weaponTypeId);
    WeaponLevel GetWeaponLevel(WeaponTypeId weaponTypeId, int level);
    EnemyConfig GetEnemyConfig(EnemyTypeId enemyId);
    HeroConfig GetHeroConfig(HeroTypeId heroId);
  }
}