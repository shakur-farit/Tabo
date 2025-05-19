using Code.Gameplay.Features.Enchants;
using Code.Gameplay.Features.Enchants.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.UI.EnchantHolder.Behaviours;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.EnchantHolder.Factory
{
	public class EnchantUIFactory : IEnchantUIFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public EnchantUIFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public EnchantUI CreateEnchantVisual(EnchantTypeId typeId, Transform parent)
		{
			EnchantConfig config = _staticDataService.GetEnchantConfig(typeId);

			EnchantUI enchant = _instantiator.InstantiatePrefabForComponent<EnchantUI>(config.ViewPrefab, parent);
			enchant.Set(config);

			return enchant;
		}
	}
}