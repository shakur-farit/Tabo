using System.Collections.Generic;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Weapon.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponShopItemsHolder : MonoBehaviour
	{
		[SerializeField] private Transform _layout;

		private IStaticDataService _staticDataService;
		private IWeaponShopItemFactory _factory;

		[Inject]
		public void Constructor(IStaticDataService staticDataService, IWeaponShopItemFactory factory)
		{
			_staticDataService = staticDataService;
			_factory = factory;
		}

		private void Start()
		{
			IEnumerable<WeaponShopItemConfig> configs = _staticDataService.GetAllWeaponShopItemConfigs();

			foreach (WeaponShopItemConfig config in configs)
			{
				WeaponShopItem item =_factory.CreateWeaponShopItem(config, _layout);
				item.Setup(config);
			}
		}
	}
}