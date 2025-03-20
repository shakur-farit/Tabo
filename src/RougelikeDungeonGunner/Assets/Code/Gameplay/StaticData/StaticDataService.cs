using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Ammo.Config;
using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Hero;
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

		private Dictionary<AmmoId, AmmoConfig> _ammoById;
		private Dictionary<WeaponTypeId, WeaponConfig> _weaponById;
		private Dictionary<EnemyTypeId, EnemyConfig> _enemyById;
		private Dictionary<HeroTypeId, HeroConfig> _heroById;

		private readonly IAssetProvider _assetProvider;

		public StaticDataService(IAssetProvider assetProvider) =>
			_assetProvider = assetProvider;

		public async UniTask Load()
		{
			await LoadAbilities();
			await LoadWeapons();
			await LoadEnemies();
			await LoadHeroes();
		}

		public AmmoConfig GetAmmoConfig(AmmoId ammoId)
		{
			if (_ammoById.TryGetValue(ammoId, out AmmoConfig config))
				return config;

			throw new Exception($"Ammo config for {ammoId} was not found");
		}

		public AmmoLevel GetAmmoLevel(AmmoId ammoId, int level)
		{
			AmmoConfig config = GetAmmoConfig(ammoId);

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

		private async UniTask LoadAbilities() =>
			_ammoById = (await _assetProvider.LoadAll<AmmoConfig>(AmmoConfig))
				.ToDictionary(x => x.AmmoId, x => x);

		private async UniTask LoadWeapons() =>
			_weaponById = (await _assetProvider.LoadAll<WeaponConfig>(WeaponConfigLabel))
				.ToDictionary(x => x.weaponTypeId, x => x);

		private async UniTask LoadEnemies() =>
			_enemyById = (await _assetProvider.LoadAll<EnemyConfig>(EnemyConfigLabel))
				.ToDictionary(x => x.EnemyTypeId, x => x);

		private async UniTask LoadHeroes() =>
			_heroById = (await _assetProvider.LoadAll<HeroConfig>(HeroConfigLabel))
				.ToDictionary(x => x.HeroTypeId, x => x);
	}
}