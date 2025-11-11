using Code.Gameplay.StaticData;
using Code.Meta.Features.Information.EnchantInformation.Behaviours;
using Code.Meta.Features.Information.EnchantInformation.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Information.EnchantInformation.Factory
{
	public class EnchantStatUIEntryFactory : IEnchantStatUIEntryFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public EnchantStatUIEntryFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public void CreateWeaponEnchantUIEntryItem(EnchantStatUIEntryTypeId id, Transform parent, string value)
		{
			EnchantStatUIEntryConfig config = _staticDataService.GetEnchantStatUIEntryItemConfig(id);
			EnchantStatUIEntryItem item = _instantiator
				.InstantiatePrefabForComponent<EnchantStatUIEntryItem>(config.ViewPrefab, parent);

			item.Initialize(id, value);
		}
	}
}