using System;
using System.Collections.Generic;
using System.Linq;
using Code.Common;
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
using Code.Meta.Features.Shop.Upgrade;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Meta.Features.Shop.Weapon;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Configs;
using Code.Meta.Features.Shop.WeaponStatUIEntry;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Configs;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Config;
using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
	public class StaticDataService : IStaticDataService
	{
		private const string BalanceConfigPath = "BalanceConfig";
		private const string AmmoConfigLabel = "AmmoConfig";
		private const string WeaponConfigLabel = "WeaponConfig";
		private const string EnemyConfigLabel = "EnemyConfig";
		private const string HeroConfigLabel = "HeroConfig";
		private const string LevelConfigLabel = "LevelConfig";
		private const string LootConfigLabel = "LootConfig";
		private const string EnchantConfigLabel = "EnchantConfig";
		private const string WindowConfigLabel = "WindowConfig";
		private const string WeaponShopItemConfigLabel = "WeaponShopItemConfig";
		private const string EnchantShopItemConfigLabel = "EnchantShopItemConfig";
		private const string WeaponUpgradeShopItemConfigLabel = "WeaponUpgradeShopItemConfig";
		private const string WeaponStatUIEntryConfigLabel = "WeaponStatUIEntryConfig";
		private const string WeaponEnchantUIEntryConfigLabel = "WeaponEnchantUIEntryConfig";
		private const string WeaponEnchantStatUIEntryConfigLabel = "WeaponEnchantStatUIEntryConfig";

		private BalanceConfig _balance;
		private Dictionary<AmmoTypeId, AmmoConfig> _ammoById;
		private Dictionary<WeaponTypeId, WeaponConfig> _weaponById;
		private Dictionary<EnemyTypeId, EnemyConfig> _enemyById;
		private Dictionary<HeroTypeId, HeroConfig> _heroById;
		private Dictionary<LevelTypeId, LevelConfig> _levelById;
		private Dictionary<LootTypeId, LootConfig> _lootById;
		private Dictionary<EnchantTypeId, EnchantConfig> _enchantById;
		private Dictionary<WindowId, WindowConfig> _windowById;
		private Dictionary<WeaponShopItemTypeId, WeaponShopItemConfig> _weaponShopItemById;
		private Dictionary<EnchantShopItemTypeId, EnchantShopItemConfig> _enchantShopItemById;
		private Dictionary<WeaponUpgradeTypeId, WeaponUpgradeShopItemConfig> _weaponUpgradeShopItemById;
		private Dictionary<WeaponStatUIEntryTypeId, WeaponStatUIEntryConfig> _weaponStatUIEntryItemById;
		private Dictionary<WeaponEnchantUIEntryTypeId, WeaponEnchantUIEntryConfig> _weaponEnchantUIEntryItemById;

		private Dictionary<WeaponEnchantStatUIEntryTypeId, WeaponEnchantStatUIEntryConfig>
			_weaponEnchantStatUIEntryItemById;

		private readonly IAssetProvider _assetProvider;

		public IEnumerable<LootConfig> GetAllLootConfigs() => _lootById.Values;
		public IEnumerable<HeroConfig> GetAllHeroConfigs() => _heroById.Values;

		public StaticDataService(IAssetProvider assetProvider) =>
			_assetProvider = assetProvider;

		public async UniTask Load()
		{
			await LoadBalance();
			await LoadAbilities();
			await LoadWeapons();
			await LoadEnemies();
			await LoadHeroes();
			await LoadLevels();
			await LoadLoots();
			await LoadEnchants();
			await LoadWindows();
			await LoadWeaponShopItem();
			await LoadEnchantShopItem();
			await LoadWeaponUpgradeShopItem();
			await LoadWeaponStatUIEntryItem();
			await LoadWeaponEnchantUIEntryItem();
			await LoadWeaponEnchantStatUIEntryItem();
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

		public WeaponEnchantUIEntryConfig GetWeaponEnchantUIEntryItemConfig(WeaponEnchantUIEntryTypeId id)
		{
			if (_weaponEnchantUIEntryItemById.TryGetValue(id, out WeaponEnchantUIEntryConfig config))
				return config;

			throw new Exception($"Weapon enchant ui entry item config for {id} was not found");
		}

		public WeaponEnchantStatUIEntryConfig GetWeaponEnchantStatUIEntryItemConfig(WeaponEnchantStatUIEntryTypeId id)
		{
			if (_weaponEnchantStatUIEntryItemById.TryGetValue(id, out WeaponEnchantStatUIEntryConfig config))
				return config;

			throw new Exception($"Weapon enchant stat ui entry item config for {id} was not found");
		}

		public BalanceConfig GetBalance() =>
			_balance;

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
			_weaponUpgradeShopItemById =
				(await _assetProvider.LoadAll<WeaponUpgradeShopItemConfig>(WeaponUpgradeShopItemConfigLabel))
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

		private async UniTask LoadWeaponEnchantUIEntryItem() =>
			_weaponEnchantUIEntryItemById = 
				(await _assetProvider.LoadAll<WeaponEnchantUIEntryConfig>(WeaponEnchantUIEntryConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadWeaponEnchantStatUIEntryItem() =>
			_weaponEnchantStatUIEntryItemById = 
				(await _assetProvider.LoadAll<WeaponEnchantStatUIEntryConfig>(WeaponEnchantStatUIEntryConfigLabel))
				.ToDictionary(x => x.TypeId, x => x);

		private async UniTask LoadBalance() =>
			_balance = await _assetProvider.Load<BalanceConfig>(BalanceConfigPath);
	}
}