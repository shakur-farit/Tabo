using Code.Gameplay.Features.Abilities;
using Code.Gameplay.Features.Abilities.Config;
using Code.Gameplay.Features.Weapon;
using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
  public interface IStaticDataService
  {
    UniTask Load();
    AbilityConfig GetAbilityConfig(AbilityId abilityId);
    AbilityLevel GetAbilityLevel(AbilityId abilityId, int level);
    WeaponConfig GetWeaponConfig(WeaponId weaponId);
    WeaponLevel GetWeaponLevel(WeaponId weaponId, int level);
  }
}