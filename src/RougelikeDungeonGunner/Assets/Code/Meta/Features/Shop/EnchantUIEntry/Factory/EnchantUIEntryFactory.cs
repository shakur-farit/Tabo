using Assets.Code.Gameplay.Features.Statuses;
using Assets.Code.Gameplay.StaticData;
using Assets.Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Assets.Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using UnityEngine;
using Zenject;

namespace Assets.Code.Meta.Features.Shop.EnchantUIEntry.Factory
{
	public class EnchantUIEntryFactory : IEnchantUIEntryFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public EnchantUIEntryFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public void CreateWeaponEnchantUIEntryItem(EnchantUIEntryTypeId id, Transform parent, StatusSetup setup)
		{
			EnchantUIEntryConfig config = _staticDataService.GetEnchantUIEntryItemConfig(id);
			EnchantUIEntryItem item = _instantiator
				.InstantiatePrefabForComponent<EnchantUIEntryItem>(config.ViewPrefab, parent);

			item.Setup(id ,config.Sprite, setup);
		}
	}
}