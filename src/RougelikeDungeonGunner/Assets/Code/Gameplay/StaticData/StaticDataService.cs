using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Ammo.Config;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Enemy.Configs;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Levels;
using Code.Gameplay.Features.Levels.Configs;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Infrastructure.AssetManagement;
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

		private Dictionary<AmmoTypeId, AmmoConfig> _ammoById;
		private Dictionary<WeaponTypeId, WeaponConfig> _weaponById;
		private Dictionary<EnemyTypeId, EnemyConfig> _enemyById;
		private Dictionary<HeroTypeId, HeroConfig> _heroById;
		private Dictionary<LevelTypeId, LevelConfig> _levelById;

		private readonly IAssetProvider _assetProvider;

		public StaticDataService(IAssetProvider assetProvider) =>
			_assetProvider = assetProvider;

		public async UniTask Load()
		{
			await LoadAbilities();
			await LoadWeapons();
			await LoadEnemies();
			await LoadHeroes();
			await LoadLevels();
		}

		public AmmoConfig GetAmmoConfig(AmmoTypeId ammoTypeId)
		{
			if (_ammoById.TryGetValue(ammoTypeId, out AmmoConfig config))
				return config;

			throw new Exception($"Ammo config for {ammoTypeId} was not found");
		}

		public AmmoLevel GetAmmoLevel(AmmoTypeId ammoTypeId, int level)
		{
			AmmoConfig config = GetAmmoConfig(ammoTypeId);

			if (level > config.Levels.Count)
				level = config.Levels.Count;

			return config.Levels[level - 1];
		}

		public WeaponConfig GetWeaponConfig(WeaponTypeId weaponTypeId)
		{
			if (_weaponById.TryGetValue(weaponTypeId, out WeaponConfig config))
				return config;

			throw new Exception($"Weapon config for {weaponTypeId} was not found");
		}

		public WeaponLevel GetWeaponLevel(WeaponTypeId weaponTypeId, int level)
		{
			WeaponConfig config = GetWeaponConfig(weaponTypeId);

			if (level > config.Levels.Count)
				level = config.Levels.Count;

			return config.Levels[level - 1];
		}

		public EnemyConfig GetEnemyConfig(EnemyTypeId enemyId)
		{
			if (_enemyById.TryGetValue(enemyId, out EnemyConfig config))
				return config;

			throw new Exception($"Enemy config for {enemyId} was not found");
		}

		public HeroConfig GetHeroConfig(HeroTypeId heroId)
		{
			if (_heroById.TryGetValue(heroId, out HeroConfig config))
				return config;

			throw new Exception($"Hero config for {heroId} was not found");
		}

		public LevelConfig GetLevelConfig(LevelTypeId levelId)
		{
			if (_levelById.TryGetValue(levelId, out LevelConfig config))
				return config;

			throw new Exception($"Level config for {levelId} was not found");
		}

		private async UniTask LoadAbilities() =>
			_ammoById = (await _assetProvider.LoadAll<AmmoConfig>(AmmoConfig))
				.ToDictionary(x => x.ammoTypeId, x => x);

		private async UniTask LoadWeapons() =>
			_weaponById = (await _assetProvider.LoadAll<WeaponConfig>(WeaponConfigLabel))
				.ToDictionary(x => x.WeaponTypeId, x => x);

		private async UniTask LoadEnemies() =>
			_enemyById = (await _assetProvider.LoadAll<EnemyConfig>(EnemyConfigLabel))
				.ToDictionary(x => x.EnemyTypeId, x => x);

		private async UniTask LoadHeroes() =>
			_heroById = (await _assetProvider.LoadAll<HeroConfig>(HeroConfigLabel))
				.ToDictionary(x => x.HeroTypeId, x => x);
		
		private async UniTask LoadLevels() =>
			_levelById = (await _assetProvider.LoadAll<LevelConfig>(LevelConfigLabel))
				.ToDictionary(x => x.LevelTypeId, x => x);
	}
}