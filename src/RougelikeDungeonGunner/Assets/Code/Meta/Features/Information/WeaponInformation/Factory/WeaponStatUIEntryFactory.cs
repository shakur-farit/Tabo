using Code.Gameplay.StaticData;
using Code.Meta.Features.Information.WeaponInformation.Behaviours;
using Code.Meta.Features.Information.WeaponInformation.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Information.WeaponInformation.Factory
{
	public class WeaponStatUIEntryFactory : IWeaponStatUIEntryFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public WeaponStatUIEntryFactory(IInstantiator instantiator, IStaticDataService staticDataService)
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

			item.Initialize(config.TypeId, valueText);

			return item;
		}
	}
}