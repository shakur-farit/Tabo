using Code.Meta.Features.Shop.Weapon.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponShopItemFactory : IWeaponShopItemFactory
	{
		private readonly IInstantiator _instantiator;

		public WeaponShopItemFactory(IInstantiator instantiator) => 
			_instantiator = instantiator;

		public WeaponShopItem CreateWeaponShopItem(WeaponShopItemConfig config, Transform parent) => 
			_instantiator.InstantiatePrefabForComponent<WeaponShopItem>(config.ViewPrefab, parent);
	}
}