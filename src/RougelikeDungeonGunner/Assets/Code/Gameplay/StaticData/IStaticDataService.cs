using System.Collections.Generic;
using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.Features.Enchants;
using Code.Gameplay.Features.Enchants.Configs;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Enemy.Configs;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.Features.Levels;
using Code.Gameplay.Features.Levels.Configs;
using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Loot.Configs;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Meta;
using Code.Meta.Features.Shop.WeaponUpgrade;
using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Config;
using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
  public interface IStaticDataService
  {
	  IEnumerable<LootConfig> GetAllLootConfigs();
	  IEnumerable<HeroConfig> GetAllHeroConfigs();

	  UniTask Load();

	  AmmoConfig GetAmmoConfig(AmmoTypeId ammoTypeId);
	  AmmoLevel GetAmmoLevel(AmmoTypeId ammoTypeId, int level);
	  WeaponConfig GetWeaponConfig(WeaponTypeId weaponTypeId);
    WeaponLevel GetWeaponLevel(WeaponTypeId weaponTypeId, int level);
    EnemyConfig GetEnemyConfig(EnemyTypeId enemyId);
    HeroConfig GetHeroConfig(HeroTypeId heroId);
    LevelConfig GetLevelConfig(LevelTypeId levelId);
    LootConfig GetLootConfig(LootTypeId lootId);
    EnchantConfig GetEnchantConfig(EnchantTypeId id);
    WindowConfig GetWindowConfig(WindowId id);
    ShopWeaponUpgradeConfig GetShopWeaponUpgradeConfig(ShopWeaponUpgradeTypeId id);
  }
}