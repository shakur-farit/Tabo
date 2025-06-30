using Code.Gameplay.Features.Statuses;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory
{
	public class WeaponEnchantUIEntryFactory : IWeaponEnchantUIEntryFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public WeaponEnchantUIEntryFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public void CreateWeaponEnchantUIEntryItem(WeaponEnchantUIEntryTypeId id, Transform parent, StatusSetup setup)
		{
			WeaponEnchantUIEntryConfig config = _staticDataService.GetWeaponEnchantUIEntryItemConfig(id);
			WeaponEnchantUIEntryItem item = _instantiator
				.InstantiatePrefabForComponent<WeaponEnchantUIEntryItem>(config.ViewPrefab, parent);

			item.Setup(id ,config.Sprite, setup);
		}
	}
}