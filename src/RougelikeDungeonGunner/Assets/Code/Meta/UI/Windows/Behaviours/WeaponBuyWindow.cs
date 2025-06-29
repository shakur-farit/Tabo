using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using System.Collections.Generic;
using System.Linq;
using Code.Meta.Features.Shop.Weapon.Factory;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponBuyWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Transform _layout;

		private readonly List<GameObject> _items = new();

		private IWindowService _windowService;
		private IWeaponShopItemFactory _factory;
		private IProgressProvider _progressProvider;
		private IStaticDataService _staticDataService;


		[Inject]
		public void Constructor(
			IWindowService windowService,
			IStaticDataService staticDataService,
			IWeaponShopItemFactory factory,
			IProgressProvider progressProvider)
		{
			Id = WindowId.WeaponBuyWindow;

			_windowService = windowService;
			_staticDataService = staticDataService;
			_factory = factory;
			_progressProvider = progressProvider;

		}

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			UpdateWeaponsInShop();
		}

		protected override void SubscribeUpdates() => 
			_progressProvider.HeroData.WeaponChanged += UpdateWeaponsInShop;

		protected override void UnsubscribeUpdates() => 
			_progressProvider.HeroData.WeaponChanged -= UpdateWeaponsInShop;

		private void Close() => 
			_windowService.Close(WindowId.WeaponBuyWindow);

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