using System.Collections.Generic;
using Code.Common;
using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.Features.Dungeon;
using Code.Gameplay.Features.Dungeon.Configs;
using Code.Gameplay.Features.Enchants;
using Code.Gameplay.Features.Enchants.Configs;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Enemy.Configs;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.Features.Level;
using Code.Gameplay.Features.Level.Configs;
using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Loot.Configs;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Meta.Features.Shop.Enchant;
using Code.Meta.Features.Shop.Enchant.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Code.Meta.Features.Shop.Upgrade;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Meta.Features.Shop.Weapon;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.Features.Shop.WeaponStatUIEntry;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Configs;
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

	  BalanceConfig GetBalance();
	  AmmoConfig GetAmmoConfig(AmmoTypeId ammoTypeId);
	  WeaponConfig GetWeaponConfig(WeaponTypeId weaponTypeId);
	  EnemyConfig GetEnemyConfig(EnemyTypeId enemyId);
	  HeroConfig GetHeroConfig(HeroTypeId heroId);
	  LevelConfig GetLevelConfig(LevelTypeId levelId);
	  LootConfig GetLootConfig(LootTypeId lootId);
	  EnchantConfig GetEnchantConfig(EnchantTypeId id);
    WindowConfig GetWindowConfig(WindowId id);
    WeaponUpgradeShopItemConfig GetWeaponUpgradeShopItemConfig(WeaponUpgradeTypeId id);
    WeaponShopItemConfig GetWeaponShopItemConfig(WeaponShopItemTypeId id);
    WeaponStatUIEntryConfig GetWeaponStatUIEntryItemConfig(WeaponStatUIEntryTypeId id);
    EnchantUIEntryConfig GetEnchantUIEntryItemConfig(EnchantUIEntryTypeId id);
    EnchantStatUIEntryConfig GetEnchantStatUIEntryItemConfig(EnchantStatUIEntryTypeId id);
    EnchantShopItemConfig GetEnchantShopItemConfig(EnchantShopItemTypeId id);
    DungeonConfig GetDungeonConfig(DungeonTypeId id);
    AuraConfig GetAuraConfig(AuraTypeId id);
  }
}