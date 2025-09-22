using Assets.Code.Gameplay.Features.Enchants;
using Assets.Code.Gameplay.Features.Enchants.Configs;
using Assets.Code.Gameplay.StaticData;
using Assets.Code.Meta.Features.Hud.EnchantHolder.Behaviours;
using UnityEngine;
using Zenject;

namespace Assets.Code.Meta.Features.Hud.EnchantHolder.Factory
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