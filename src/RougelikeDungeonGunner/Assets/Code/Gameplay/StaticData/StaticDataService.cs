using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Ammo;
using Code.Gameplay.Features.Ammo.Config;
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

		private Dictionary<AmmoId, AmmoConfig> _ammoById;
		private Dictionary<WeaponId, WeaponConfig> _weaponById;

		private readonly IAssetProvider _assetProvider;

		public StaticDataService(IAssetProvider assetProvider) =>
			_assetProvider = assetProvider;

		public async UniTask Load()
		{
			await LoadAbilities();
			await LoadWeapons();
		}

		public AmmoConfig GetAmmoConfig(AmmoId ammoId)
		{
			if (_ammoById.TryGetValue(ammoId, out AmmoConfig config))
				return config;

			throw new Exception($"Ammo config for {ammoId} was not found");
		}

		public AmmoLevel GetAbilityLevel(AmmoId ammoId, int level)
		{
			AmmoConfig config = GetAmmoConfig(ammoId);

			if (level > config.Levels.Count)
				level = config.Levels.Count;

			return config.Levels[level - 1];
		}

		public WeaponConfig GetWeaponConfig(WeaponId weaponId)
		{
			if (_weaponById.TryGetValue(weaponId, out WeaponConfig config))
				return config;

			throw new Exception($"Weapon config for {weaponId} was not found");
		}

		public WeaponLevel GetWeaponLevel(WeaponId weaponId, int level)
		{
			WeaponConfig config = GetWeaponConfig(weaponId);

			if (level > config.Levels.Count)
				level = config.Levels.Count;

			return config.Levels[level - 1];
		}

		private async UniTask LoadAbilities() =>
			_ammoById = (await _assetProvider.LoadAll<AmmoConfig>(AmmoConfig))
				.ToDictionary(x => x.AmmoId, x => x);

		private async UniTask LoadWeapons() =>
			_weaponById = (await _assetProvider.LoadAll<WeaponConfig>(WeaponConfigLabel))
				.ToDictionary(x => x.WeaponId, x => x);
	}
}