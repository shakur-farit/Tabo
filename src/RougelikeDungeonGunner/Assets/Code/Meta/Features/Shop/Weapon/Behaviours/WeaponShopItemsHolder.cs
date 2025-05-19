using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Progress.Provider;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponShopItemsHolder : MonoBehaviour
	{
		[SerializeField] private Transform _layout;

		private List<GameObject> _items = new();

		private IStaticDataService _staticDataService;
		private IWeaponShopItemFactory _factory;
		private IProgressProvider _progressProvider;

		[Inject]
		public void Constructor(
			IStaticDataService staticDataService, 
			IWeaponShopItemFactory factory,
			IProgressProvider progressProvider)
		{
			_staticDataService = staticDataService;
			_factory = factory;
			_progressProvider = progressProvider;
		}

		private void Start()
		{
			_progressProvider.HeroData.WeaponChanged += UpdateWeaponsInShop;

			UpdateWeaponsInShop();
		}

		private void OnDestroy() => 
			_progressProvider.HeroData.WeaponChanged -= UpdateWeaponsInShop;

		private void UpdateWeaponsInShop()
		{
			Clear();

			 List<WeaponShopItemConfig> configs = _staticDataService.GetAllWeaponShopItemConfigs().ToList();

			foreach (WeaponShopItemConfig config in configs)
			{
				if (config.WeaponTypeId == _progressProvider.HeroData.CurrentWeaponTypeId)
					continue;

				WeaponShopItem item = _factory.CreateWeaponShopItem(config, _layout);
				item.Setup(config);
				_items.Add(item.gameObject);
			}
		}

		private void Clear()
		{
			foreach (GameObject item in _items) 
				Destroy(item);

			_items.Clear();
		}
	}
}