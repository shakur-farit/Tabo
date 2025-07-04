using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Enchant.Behaviours;
using Code.Meta.Features.Shop.Enchant.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.Enchant.Factory
{
	public class EnchantShopItemFactory : IEnchantShopItemFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public EnchantShopItemFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public EnchantShopItem CreateEnchantShopItem(EnchantShopItemTypeId id, Transform parent)
		{
			EnchantShopItemConfig config = _staticDataService.GetEnchantShopItemConfig(id);

			EnchantShopItem item = _instantiator.InstantiatePrefabForComponent<EnchantShopItem>(config.ViewPrefab, parent);
	
			item.Setup(config);

			return item;
		}
	}
}