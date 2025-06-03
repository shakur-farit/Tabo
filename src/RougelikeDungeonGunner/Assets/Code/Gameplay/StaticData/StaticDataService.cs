using System;
using System.Collections.Generic;
using System.Linq;
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
using Code.Infrastructure.AssetManagement;
using Code.Meta.Features.Shop.Weapon;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.Features.Shop.WeaponUpgrade;
using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Config;
using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
	public class StaticDataService : IStaticDataService
	{
		private const string AmmoConfig = "AmmoConfig";
		private const string WeaponConfigLabel = "WeaponConfig";
		private const string EnemyConfigLabel = "EnemyConfig";
		private const string HeroConfigLabel = "HeroConfig";
		private const string LevelConfigLabel = "LevelConfig";
		private const string LootConfigLabel = "LootConfig";
		private const string EnchantConfigLabel = "EnchantConfig";
		private const string WindowConfigLabel = "WindowConfig";
		private const string WeaponShopItemConfigLabel = "WeaponShopItemConfig";
		private const string WeaponUpgradeShopItemConfigLabel = "WeaponUpgradeShopItemConfig";

		private Dictionary<AmmoTypeId, AmmoConfig> _ammoById;
		private Dictionary<WeaponTypeId, WeaponConfig> _weaponById;
		private Dictionary<EnemyTypeId, EnemyConfig> _enemyById;
		private Dictionary<HeroTypeId, HeroConfig> _heroById;
		private Dictionary<LevelTypeId, LevelConfig> _levelById;
		private Dictionary<LootTypeId, LootConfig> _lootById;
		private Dictionary<EnchantTypeId, EnchantConfig> _enchantById;
		private Dictionary<WindowId, WindowConfig> _windowById;
		private Dictionary<WeaponShopItemTypeId, WeaponShopItemConfig> _weaponShopItemById;
		private Dictionary<WeaponUpgradeShopItemTypeId, WeaponUpgradeShopItemConfig> _weaponUpgradeShopItemById;

		private readonly IAssetProvider _assetProvider;

		public IEnumerable<LootConfig> GetAllLootConfigs() => _lootById.Values;
		public IEnumerable<HeroConfig> GetAllHeroConfigs() => _heroById.Values;
		public IEnumerable<WeaponShopItemConfig> GetAllWeaponShopItemConfigs() => _weaponShopItemById.Values;
		public IEnumerable<WeaponUpgradeShopItemConfig> GetAllWeaponUpgradeShopItemConfigs() => _weaponUpgradeShopItemById.Values;

		public StaticDataService(IAssetProvider assetProvider) =>
			_assetProvider = assetProvider;

		public async UniTask Load()
		{
			await LoadAbilities();
			await LoadWeapons();
			await LoadEnemies();
			await LoadHeroes();
			await LoadLevels();
			await LoadLoots();
			await LoadEnchants();
			await LoadWindows();
			await LoadWeaponUpgradeShopItem();
			await LoadWeaponShopItem();
		}

		public AmmoConfig GetAmmoConfig(AmmoTypeId id)
		{
			if (_ammoById.TryGetValue(id, out AmmoConfig config))
				return config;

			throw new Exception($"Ammo config for {id} was not found");
		}

		public AmmoLevel GetAmmoLevel(AmmoTypeId id, int level)
		{
			AmmoConfig config = GetAmmoConfig(id);

			if (level > config.Levels.Count)
				level = config.Levels.Count;

			return config.Levels[level - 1];
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

		public WindowConfig GetWindowConfig(WindowId id)
		{
			if (_windowById.TryGetValue(id, out WindowConfig config))
				return config;

			throw new Exception($"Window config for {id} was not found");
		}

		public WeaponUpgradeShopItemConfig GetUpgradeShopItemConfig(WeaponUpgradeShopItemTypeId id)
		{
			if (_weaponUpgradeShopItemById.TryGetValue(id, out WeaponUpgradeShopItemConfig config))
				return config;

			throw new Exception($"Weapon Upgrade config for {id} was not found");
		}

		public WeaponShopItemConfig GetWeaponShopItemConfig(WeaponShopItemTypeId id)
		{
			if (_weaponShopItemById.TryGetValue(id, out WeaponShopItemConfig config))
				return config;

			throw new Exception($"Weapon config for {id} was not found");
		}

		private async UniTask LoadAbilities() =>
			_ammoById = (await _assetProvider.LoadAll<AmmoConfig>(AmmoConfig))
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

		private async UniTask LoadLoots() =>
			_lootById = (await _assetProvider.LoadAll<LootConfig>(LootConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadEnchants() =>
			_enchantById = (await _assetProvider.LoadAll<EnchantConfig>(EnchantConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWindows() =>
			_windowById = (await _assetProvider.LoadAll<WindowConfig>(WindowConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWeaponUpgradeShopItem() =>
			_weaponUpgradeShopItemById = (await _assetProvider.LoadAll<WeaponUpgradeShopItemConfig>(WeaponUpgradeShopItemConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWeaponShopItem() =>
			_weaponShopItemById = (await _assetProvider.LoadAll<WeaponShopItemConfig>(WeaponShopItemConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);
	}
}