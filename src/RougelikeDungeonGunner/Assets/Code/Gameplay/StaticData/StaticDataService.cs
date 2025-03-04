using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Abilities;
using Code.Gameplay.Features.Abilities.Config;
using Code.Gameplay.Features.Weapon;
using Code.Infrastructure.AssetManagement;
using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
	public class StaticDataService : IStaticDataService
	{
		private const string AbilityConfig = "AbilityConfig";
		private const string WeaponConfigLabel = "WeaponConfig";

		private Dictionary<AbilityId, AbilityConfig> _abilityById;
		private Dictionary<WeaponId, WeaponConfig> _weaponById;

		private readonly IAssetProvider _assetProvider;

		public StaticDataService(IAssetProvider assetProvider) =>
			_assetProvider = assetProvider;

		public async UniTask Load()
		{
			await LoadAbilities();
			await LoadWeapons();
		}

		public AbilityConfig GetAbilityConfig(AbilityId abilityId)
		{
			if (_abilityById.TryGetValue(abilityId, out AbilityConfig config))
				return config;

			throw new Exception($"Ability config for {abilityId} was not found");
		}

		public AbilityLevel GetAbilityLevel(AbilityId abilityId, int level)
		{
			AbilityConfig config = GetAbilityConfig(abilityId);

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
			_abilityById = (await _assetProvider.LoadAll<AbilityConfig>(AbilityConfig))
				.ToDictionary(x => x.AbilityId, x => x);

		private async UniTask LoadWeapons() =>
			_weaponById = (await _assetProvider.LoadAll<WeaponConfig>(WeaponConfigLabel))
				.ToDictionary(x => x.WeaponId, x => x);
	}
}