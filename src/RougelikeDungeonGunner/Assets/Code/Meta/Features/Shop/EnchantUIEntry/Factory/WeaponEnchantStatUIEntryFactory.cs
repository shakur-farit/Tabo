using Assets.Code.Gameplay.StaticData;
using Assets.Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Assets.Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using UnityEngine;
using Zenject;

namespace Assets.Code.Meta.Features.Shop.EnchantUIEntry.Factory
{
	public class WeaponEnchantStatUIEntryFactory : IWeaponEnchantStatUIEntryFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public WeaponEnchantStatUIEntryFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public void CreateWeaponEnchantUIEntryItem(EnchantStatUIEntryTypeId id, Transform parent, string value)
		{
			EnchantStatUIEntryConfig config = _staticDataService.GetEnchantStatUIEntryItemConfig(id);
			EnchantStatUIEntryItem item = _instantiator
				.InstantiatePrefabForComponent<EnchantStatUIEntryItem>(config.ViewPrefab, parent);

			item.Setup(id, value);
		}
	}
}