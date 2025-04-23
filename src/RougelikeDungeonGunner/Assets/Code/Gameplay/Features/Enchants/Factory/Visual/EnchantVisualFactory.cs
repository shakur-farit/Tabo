using Code.Gameplay.Features.Enchants.Configs;
using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Enchants.Factory
{
	public class EnchantVisualFactory : IEnchantVisualFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public EnchantVisualFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public EnchantVisual CreateEnchantVisual(EnchantTypeId typeId, Transform parent)
		{
			EnchantConfig config = _staticDataService.GetEnchantConfig(typeId);

			EnchantVisual enchant = _instantiator.InstantiatePrefabForComponent<EnchantVisual>(config.ViewPrefab, parent);
			enchant.Set(config);
			Debug.Log("Create");

			return enchant;
		}
	}
}