using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory
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

		public void CreateWeaponEnchantUIEntryItem(WeaponEnchantStatUIEntryTypeId id, Transform parent, string value)
		{
			WeaponEnchantStatUIEntryConfig config = _staticDataService.GetWeaponEnchantStatUIEntryItemConfig(id);
			WeaponEnchantStatUIEntryItem item = _instantiator
				.InstantiatePrefabForComponent<WeaponEnchantStatUIEntryItem>(config.ViewPrefab, parent);

			item.Setup(id, value);
		}
	}
}