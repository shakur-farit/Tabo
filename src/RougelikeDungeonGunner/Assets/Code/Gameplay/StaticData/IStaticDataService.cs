using System.Collections.Generic;
using Assets.Code.Common.Balance;
using Assets.Code.Gameplay.Features.Ammo;
using Assets.Code.Gameplay.Features.Ammo.Configs;
using Assets.Code.Gameplay.Features.Aura;
using Assets.Code.Gameplay.Features.Aura.Configs;
using Assets.Code.Gameplay.Features.Dungeon;
using Assets.Code.Gameplay.Features.Dungeon.Configs;
using Assets.Code.Gameplay.Features.Enchants;
using Assets.Code.Gameplay.Features.Enchants.Configs;
using Assets.Code.Gameplay.Features.Enemy;
using Assets.Code.Gameplay.Features.Enemy.Configs;
using Assets.Code.Gameplay.Features.Hero;
using Assets.Code.Gameplay.Features.Hero.Configs;
using Assets.Code.Gameplay.Features.Level;
using Assets.Code.Gameplay.Features.Level.Configs;
using Assets.Code.Gameplay.Features.Loot;
using Assets.Code.Gameplay.Features.Loot.Configs;
using Assets.Code.Gameplay.Features.SpecialEffect;
using Assets.Code.Gameplay.Features.SpecialEffect.Configs;
using Assets.Code.Gameplay.Features.Weapon;
using Assets.Code.Gameplay.Features.Weapon.Configs;
using Assets.Code.Meta.Features.Shop.Enchant;
using Assets.Code.Meta.Features.Shop.Enchant.Configs;
using Assets.Code.Meta.Features.Shop.EnchantUIEntry;
using Assets.Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Assets.Code.Meta.Features.Shop.Upgrade;
using Assets.Code.Meta.Features.Shop.Upgrade.Configs;
using Assets.Code.Meta.Features.Shop.Weapon;
using Assets.Code.Meta.Features.Shop.Weapon.Configs;
using Assets.Code.Meta.Features.Shop.WeaponStatUIEntry;
using Assets.Code.Meta.Features.Shop.WeaponStatUIEntry.Configs;
using Assets.Code.Meta.UI.Windows;
using Assets.Code.Meta.UI.Windows.Config;
using Code.Common;
using Cysharp.Threading.Tasks;

namespace Assets.Code.Gameplay.StaticData
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
    SpecialEffectConfig GetSpecialEffectConfig(SpecialEffectTypeId typeId);
  }
}