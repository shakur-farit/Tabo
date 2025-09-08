using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.Weapon.Configs;
using UnityEngine;
using Zenject;
using static UnityEditor.Progress;

namespace Code.Meta.Features.Shop.Weapon.Factory
{
	public class WeaponShopItemFactory : IWeaponShopItemFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public WeaponShopItemFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public WeaponShopItem CreateWeaponShopItem(WeaponShopItemTypeId id, Transform parent)
		{
			WeaponShopItemConfig config = _staticDataService.GetWeaponShopItemConfig(id);
			WeaponShopItem item = _instantiator.InstantiatePrefabForComponent<WeaponShopItem>(config.ViewPrefab, parent);
			item.Setup(config);
			return item;
		}
	}
}