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
using Code.Gameplay.Features.SpecialEffect;
using Code.Gameplay.Features.SpecialEffect.Configs;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Infrastructure.AssetManagement;
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
using System;
using System.Collections.Generic;
using System.Linq;
using Code.Infrastructure.ObjectPool.Config;
using Code.Sounds.Music;
using Code.Sounds.Music.Configs;
using Code.Sounds.SoundEffects;
using Code.Sounds.SoundEffects.Config;

namespace Code.Gameplay.StaticData
{
	public class StaticDataService : IStaticDataService
	{
		private const string BalanceConfigPath = "BalanceConfig";
		private const string ObjectPoolConfigPath = "ObjectPoolConfig";
		private const string AmmoConfigLabel = "AmmoConfig";
		private const string WeaponConfigLabel = "WeaponConfig";
		private const string EnemyConfigLabel = "EnemyConfig";
		private const string HeroConfigLabel = "HeroConfig";
		private const string LevelConfigLabel = "LevelConfig";
		private const string DungeonConfigLabel = "DungeonConfig";
		private const string LootConfigLabel = "LootConfig";
		private const string EnchantConfigLabel = "EnchantConfig";
		private const string AuraConfigLabel = "AuraConfig";
		private const string SpecialEffectConfigLabel = "SpecialEffectConfig";
    private const string DestroyableItemConfigLabel = "DestroyableItemConfig";
    private const string DoorConfigLabel = "DoorConfig";
    private const string WindowConfigLabel = "WindowConfig";
    private const string WeaponShopItemConfigLabel = "WeaponShopItemConfig";
		private const string EnchantShopItemConfigLabel = "EnchantShopItemConfig";
		private const string WeaponUpgradeShopItemConfigLabel = "WeaponUpgradeShopItemConfig";
		private const string HeroUpgradeShopItemConfigLabel = "HeroUpgradeShopItemConfig";
		private const string WeaponStatUIEntryConfigLabel = "WeaponStatUIEntryConfig";
    private const string EnchantUIEntryConfigLabel = "EnchantUIEntryConfig";
    private const string EnchantStatUIEntryConfigLabel = "EnchantStatUIEntryConfig";
    private const string MusicConfigLabel = "MusicConfig";
    private const string SoundEffectConfigLabel = "SoundEffectConfig";

    private BalanceConfig _balance;
    private ObjectPoolConfig _objectPool;
    private Dictionary<AmmoTypeId, AmmoConfig> _ammoById;
    private Dictionary<WeaponTypeId, WeaponConfig> _weaponById;
    private Dictionary<EnemyTypeId, EnemyConfig> _enemyById;
    private Dictionary<HeroTypeId, HeroConfig> _heroById;
    private Dictionary<LevelTypeId, LevelConfig> _levelById;
    private Dictionary<DungeonTypeId, DungeonConfig> _dungeonById;
    private Dictionary<LootTypeId, LootConfig> _lootById;
    private Dictionary<EnchantTypeId, EnchantConfig> _enchantById;
    private Dictionary<AuraTypeId, AuraConfig> _auraById;
    private Dictionary<DestroyableItemTypeId, DestroyableItemConfig> _destroyableItemById;
    private Dictionary<DoorTypeId, DoorConfig> _doorById;
    private Dictionary<WindowId, WindowConfig> _windowById;
    private Dictionary<WeaponShopItemTypeId, WeaponShopItemConfig> _weaponShopItemById;
    private Dictionary<WeaponUpgradeTypeId, WeaponUpgradeShopItemConfig> _weaponUpgradeShopItemById;
    private Dictionary<WeaponStatUIEntryTypeId, WeaponStatUIEntryConfig> _weaponStatUIEntryItemById;
    private Dictionary<EnchantShopItemTypeId, EnchantShopItemConfig> _enchantShopItemById;
    private Dictionary<EnchantUIEntryTypeId, EnchantUIEntryConfig> _enchantUIEntryItemById;
    private Dictionary<SpecialEffectTypeId, SpecialEffectConfig> _specialEffectById;
    private Dictionary<EnchantStatUIEntryTypeId, EnchantStatUIEntryConfig>
			_weaponEnchantStatUIEntryItemById;
    private Dictionary<HeroUpgradeTypeId, HeroUpgradeShopItemConfig> _heroUpgradeShopItemById;
    private Dictionary<MusicTypeId, MusicConfig> _musicById;
    private Dictionary<SoundEffectTypeId, SoundEffectConfig> _soundEffectById;


    private readonly IAssetProvider _assetProvider;

    public IEnumerable<LootConfig> GetAllLootConfigs() => _lootById.Values;
		public IEnumerable<HeroConfig> GetAllHeroConfigs() => _heroById.Values;
		public IEnumerable<DestroyableItemConfig> GetAllDestroyableItemConfigs() => _destroyableItemById.Values;


		public StaticDataService(IAssetProvider assetProvider) =>
			_assetProvider = assetProvider;

		public async UniTask Load()
		{
			await LoadBalance();
      await LoadObjectPool();
			await LoadAbilities();
			await LoadWeapons();
			await LoadEnemies();
			await LoadHeroes();
			await LoadLevels();
			await LoadDungeons();
			await LoadLoots();
			await LoadEnchants();
			await LoadAuras();
      await LoadDestroyableItems();
      await LoadDoors();
			await LoadSpecialEffects();
			await LoadWindows();
			await LoadWeaponShopItem();
			await LoadEnchantShopItem();
			await LoadWeaponUpgradeShopItem();
			await LoadHeroUpgradeShopItem();
			await LoadWeaponStatUIEntryItem();
			await LoadEnchantUIEntryItem();
			await LoadEnchantStatUIEntryItem();
			await LoadMusics();
      await LoadSoundEffect();
    }

		public AmmoConfig GetAmmoConfig(AmmoTypeId id)
		{
			if (_ammoById.TryGetValue(id, out AmmoConfig config))
				return config;

			throw new Exception($"Ammo config for {id} was not found");
		}

		public WeaponConfig GetWeaponConfig(WeaponTypeId id)
		{
			if (_weaponById.TryGetValue(id, out WeaponConfig config))
				return config;

			throw new Exception($"Weapon config for {id} was not found");
		}

		public EnemyConfig GetEnemyConfig(EnemyTypeId id)
		{
			if (_enemyById.TryGetValue(id, out EnemyConfig config))
				return config;

			throw new Exception($"Enemy config for {id} was not found");
		}

		public HeroConfig GetHeroConfig(HeroTypeId id)
		{
			if (_heroById.TryGetValue(id, out HeroConfig config))
				return config;

			throw new Exception($"Hero config for {id} was not found");
		}

		public LevelConfig GetLevelConfig(LevelTypeId id)
		{
			if (_levelById.TryGetValue(id, out LevelConfig config))
				return config;

			throw new Exception($"Level config for {id} was not found");
		}

		public DungeonConfig GetDungeonConfig(DungeonTypeId id)
		{
			if (_dungeonById.TryGetValue(id, out DungeonConfig config))
				return config;

			throw new Exception($"Dungeon config for {id} was not found");
		}

		public LootConfig GetLootConfig(LootTypeId id)
		{
			if (_lootById.TryGetValue(id, out LootConfig config))
				return config;

			throw new Exception($"Loot config for {id} was not found");
		}

		public EnchantConfig GetEnchantConfig(EnchantTypeId id)
		{
			if (_enchantById.TryGetValue(id, out EnchantConfig config))
				return config;

			throw new Exception($"Enchant config for {id} was not found");
		}

		public AuraConfig GetAuraConfig(AuraTypeId id)
		{
			if (_auraById.TryGetValue(id, out AuraConfig config))
				return config;

			throw new Exception($"Aura config for {id} was not found");
		}

		public SpecialEffectConfig GetSpecialEffectConfig(SpecialEffectTypeId id)
		{
			if (_specialEffectById.TryGetValue(id, out SpecialEffectConfig config))
				return config;

			throw new Exception($"Special effect config for {id} was not found");
		}

    public DestroyableItemConfig GetDestroyableItemConfig(DestroyableItemTypeId id)
    {
      if (_destroyableItemById.TryGetValue(id, out DestroyableItemConfig config))
        return config;

      throw new Exception($"Destroyable item config for {id} was not found");
    }

    public DoorConfig GetDoorConfig(DoorTypeId id)
    {
	    if (_doorById.TryGetValue(id, out DoorConfig config))
		    return config;

	    throw new Exception($"Door item config for {id} was not found");
    }

		public WindowConfig GetWindowConfig(WindowId id)
		{
			if (_windowById.TryGetValue(id, out WindowConfig config))
				return config;

			throw new Exception($"Window config for {id} was not found");
		}

		public WeaponUpgradeShopItemConfig GetWeaponUpgradeShopItemConfig(WeaponUpgradeTypeId id)
		{
			if (_weaponUpgradeShopItemById.TryGetValue(id, out WeaponUpgradeShopItemConfig config))
				return config;

			throw new Exception($"Weapon upgrade item config for {id} was not found");
		}

		public WeaponShopItemConfig GetWeaponShopItemConfig(WeaponShopItemTypeId id)
		{
			if (_weaponShopItemById.TryGetValue(id, out WeaponShopItemConfig config))
				return config;

			throw new Exception($"Weapon shop item config for {id} was not found");
		}

		public EnchantShopItemConfig GetEnchantShopItemConfig(EnchantShopItemTypeId id)
		{
			if (_enchantShopItemById.TryGetValue(id, out EnchantShopItemConfig config))
				return config;

			throw new Exception($"Enchant shop item config for {id} was not found");
		}

		public WeaponStatUIEntryConfig GetWeaponStatUIEntryItemConfig(WeaponStatUIEntryTypeId id)
		{
			if (_weaponStatUIEntryItemById.TryGetValue(id, out WeaponStatUIEntryConfig config))
				return config;

			throw new Exception($"Weapon stat ui entry item config for {id} was not found");
		}

		public EnchantUIEntryConfig GetEnchantUIEntryItemConfig(EnchantUIEntryTypeId id)
		{
			if (_enchantUIEntryItemById.TryGetValue(id, out EnchantUIEntryConfig config))
				return config;

			throw new Exception($"Enchant ui entry item config for {id} was not found");
		}

		public EnchantStatUIEntryConfig GetEnchantStatUIEntryItemConfig(EnchantStatUIEntryTypeId id)
		{
			if (_weaponEnchantStatUIEntryItemById.TryGetValue(id, out EnchantStatUIEntryConfig config))
				return config;

			throw new Exception($"Enchant stat ui entry item config for {id} was not found");
		}

		public HeroUpgradeShopItemConfig GetHeroUpgradeShopItemConfig(HeroUpgradeTypeId id)
		{
			if (_heroUpgradeShopItemById.TryGetValue(id, out HeroUpgradeShopItemConfig config))
				return config;

			throw new Exception($"Hero upgrade shop item config for {id} was not found");

		}

		public MusicConfig GetMusicConfig(MusicTypeId id)
		{
			if (_musicById.TryGetValue(id, out MusicConfig config))
				return config;

			throw new Exception($"Music config for {id} was not found");
		}

		public SoundEffectConfig GetSoundEffectConfig(SoundEffectTypeId id)
    {
      if (_soundEffectById.TryGetValue(id, out SoundEffectConfig config))
        return config;

      throw new Exception($"Sound effect config for {id} was not found");
    }

		public BalanceConfig GetBalance() =>
			_balance;

    public ObjectPoolConfig GetObjectPoolConfig() => 
      _objectPool;

    private async UniTask LoadAbilities() =>
			_ammoById = (await _assetProvider.LoadAll<AmmoConfig>(AmmoConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWeapons() =>
			_weaponById = (await _assetProvider.LoadAll<WeaponConfig>(WeaponConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadEnemies() =>
			_enemyById = (await _assetProvider.LoadAll<EnemyConfig>(EnemyConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadHeroes() =>
			_heroById = (await _assetProvider.LoadAll<HeroConfig>(HeroConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadLevels() =>
			_levelById = (await _assetProvider.LoadAll<LevelConfig>(LevelConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadDungeons() =>
			_dungeonById = (await _assetProvider.LoadAll<DungeonConfig>(DungeonConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadLoots() =>
			_lootById = (await _assetProvider.LoadAll<LootConfig>(LootConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadEnchants() =>
			_enchantById = (await _assetProvider.LoadAll<EnchantConfig>(EnchantConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadSpecialEffects() =>
			_specialEffectById =
				(await _assetProvider.LoadAll<SpecialEffectConfig>(SpecialEffectConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadAuras() =>
			_auraById = (await _assetProvider.LoadAll<AuraConfig>(AuraConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

    private async UniTask LoadDestroyableItems() =>
      _destroyableItemById = (await _assetProvider.LoadAll<DestroyableItemConfig>(DestroyableItemConfigLabel))
        .ToDictionary(x => x.TypeId, x => x);

    private async UniTask LoadDoors() =>
	    _doorById = (await _assetProvider.LoadAll<DoorConfig>(DoorConfigLabel))
		    .ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWindows() =>
			_windowById = (await _assetProvider.LoadAll<WindowConfig>(WindowConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWeaponUpgradeShopItem() =>
			_weaponUpgradeShopItemById =
				(await _assetProvider.LoadAll<WeaponUpgradeShopItemConfig>(WeaponUpgradeShopItemConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadHeroUpgradeShopItem() =>
			_heroUpgradeShopItemById =
				(await _assetProvider.LoadAll<HeroUpgradeShopItemConfig>(HeroUpgradeShopItemConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWeaponShopItem() =>
			_weaponShopItemById = (await _assetProvider.LoadAll<WeaponShopItemConfig>(WeaponShopItemConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadEnchantShopItem() =>
			_enchantShopItemById = (await _assetProvider.LoadAll<EnchantShopItemConfig>(EnchantShopItemConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWeaponStatUIEntryItem() =>
			_weaponStatUIEntryItemById = (await _assetProvider.LoadAll<WeaponStatUIEntryConfig>(WeaponStatUIEntryConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadEnchantUIEntryItem() =>
			_enchantUIEntryItemById = 
				(await _assetProvider.LoadAll<EnchantUIEntryConfig>(EnchantUIEntryConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadEnchantStatUIEntryItem() =>
			_weaponEnchantStatUIEntryItemById = 
				(await _assetProvider.LoadAll<EnchantStatUIEntryConfig>(EnchantStatUIEntryConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadMusics() =>
			_musicById = (await _assetProvider.LoadAll<MusicConfig>(MusicConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

    private async UniTask LoadSoundEffect() =>
      _soundEffectById = (await _assetProvider.LoadAll<SoundEffectConfig>(SoundEffectConfigLabel))
        .ToDictionary(x => x.TypeId, x => x);

    private async UniTask LoadBalance() =>
			_balance = await _assetProvider.Load<BalanceConfig>(BalanceConfigPath);

    private async UniTask LoadObjectPool() =>
      _objectPool = await _assetProvider.Load<ObjectPoolConfig>(ObjectPoolConfigPath);
  }
}