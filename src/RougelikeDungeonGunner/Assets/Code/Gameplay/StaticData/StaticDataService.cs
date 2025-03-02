using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Abilities;
using Code.Infrastructure.AssetManagement;
using Cysharp.Threading.Tasks;

namespace Code.Gameplay.StaticData
{
  public class StaticDataService : IStaticDataService
  {
	  private const string AbilityConfig = "AbilityConfig";

	  private Dictionary<AbilityId, AbilityConfig> _abilityById;

	  private readonly IAssetProvider _assetProvider;

	  public StaticDataService(IAssetProvider assetProvider) => 
      _assetProvider = assetProvider;

	  public async UniTask Load()
	  {
		  await LoadAbilities();
	  }

	  public AbilityConfig GetAbilityConfig(AbilityId abilityId)
	  {
			if(_abilityById.TryGetValue(abilityId, out AbilityConfig config))
				return config;

			throw new Exception($"Ability config for {abilityId} was not found");
	  }

	  public AbilityLevel GetAbilityLevel(AbilityId abilityId, int level)
	  {
			AbilityConfig config = GetAbilityConfig(abilityId);

			if (level > config.Levels.Count) 
				level = config.Levels.Count;

			return config.Levels[level -  1];
	  }

	  private async UniTask LoadAbilities() =>
		  _abilityById = (await _assetProvider.LoadAll<AbilityConfig>(AbilityConfig))
			  .ToDictionary(x =>x.AbilityId, x => x);
  }
}