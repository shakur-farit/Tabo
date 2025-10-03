using System.Collections.Generic;
using Code.Common.Balance;
using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.Features.Aura;
using Code.Gameplay.Features.Aura.Configs;
using Code.Gameplay.Features.Destroyable;
using Code.Gameplay.Features.Destroyable.Configs;
using Code.Gameplay.Features.Door;
using Code.Gameplay.Features.Door.Configs;
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
using Code.Gameplay.Features.Music;
using Code.Gameplay.Features.Music.Configs;
using Code.Gameplay.Features.SpecialEffect;
using Code.Gameplay.Features.SpecialEffect.Configs;
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
    IEnumerable<DestroyableItemConfig> GetAllDestroyableItemConfigs();

    UniTask Load();

    BalanceConfig GetBalance();
    DungeonConfig GetDungeonConfig(DungeonTypeId id);
    AmmoConfig GetAmmoConfig(AmmoTypeId ammoTypeId);
    WeaponConfig GetWeaponConfig(WeaponTypeId weaponTypeId);
    EnemyConfig GetEnemyConfig(EnemyTypeId enemyId);
    HeroConfig GetHeroConfig(HeroTypeId heroId);
    LevelConfig GetLevelConfig(LevelTypeId levelId);
    LootConfig GetLootConfig(LootTypeId lootId);
    EnchantConfig GetEnchantConfig(EnchantTypeId id);
    AuraConfig GetAuraConfig(AuraTypeId id);
    SpecialEffectConfig GetSpecialEffectConfig(SpecialEffectTypeId typeId);
    DestroyableItemConfig GetDestroyableItemConfig(DestroyableItemTypeId id);
    DoorConfig GetDoorConfig(DoorTypeId id);
    WindowConfig GetWindowConfig(WindowId id);
    WeaponUpgradeShopItemConfig GetWeaponUpgradeShopItemConfig(WeaponUpgradeTypeId id);
    WeaponShopItemConfig GetWeaponShopItemConfig(WeaponShopItemTypeId id);
    WeaponStatUIEntryConfig GetWeaponStatUIEntryItemConfig(WeaponStatUIEntryTypeId id);
    EnchantUIEntryConfig GetEnchantUIEntryItemConfig(EnchantUIEntryTypeId id);
    EnchantStatUIEntryConfig GetEnchantStatUIEntryItemConfig(EnchantStatUIEntryTypeId id);
    EnchantShopItemConfig GetEnchantShopItemConfig(EnchantShopItemTypeId id);
    MusicConfig GetMusicConfig(MusicTypeId typeId);
    SoundEffectConfig GetSoundEffectConfig(SoundEffectTypeId id);
  }
}