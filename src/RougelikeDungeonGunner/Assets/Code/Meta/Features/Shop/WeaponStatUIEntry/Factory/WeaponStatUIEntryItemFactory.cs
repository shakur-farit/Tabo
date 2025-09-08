using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Factory
{
	public class WeaponStatUIEntryItemFactory : IWeaponStatUIEntryItemFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public WeaponStatUIEntryItemFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		

		public WeaponStatUIEntryItem CreateStatUIEntryItem(WeaponStatUIEntryTypeId id, Transform parent,
			string valueText)
		{
			WeaponStatUIEntryConfig config = _staticDataService.GetWeaponStatUIEntryItemConfig(id);

			WeaponStatUIEntryItem item = _instantiator
				.InstantiatePrefabForComponent<WeaponStatUIEntryItem>(config.ViewPrefab, parent);

			item.Setup(config.TypeId, valueText);

			return item;
		}
	}
}