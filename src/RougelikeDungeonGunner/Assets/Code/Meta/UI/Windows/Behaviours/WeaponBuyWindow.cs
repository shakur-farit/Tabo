using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Meta.Features.Shop.Weapon;
using Code.Meta.Features.Shop.Weapon.Factory;
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


		[Inject]
		public void Constructor(
			IWindowService windowService,
			IWeaponShopItemFactory factory,
			IProgressProvider progressProvider)
		{
			Id = WindowId.WeaponBuyWindow;

			_windowService = windowService;
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

			List<WeaponShopItemTypeId> ids = EnumUtility.InitEnumList<WeaponShopItemTypeId>();

			foreach (WeaponShopItemTypeId id in ids)
			{
				WeaponShopItem item = _factory.CreateWeaponShopItem(id, _layout);

				if (item.WeaponToBuy == _progressProvider.HeroData.CurrentWeaponTypeId)
					Destroy(item.gameObject);
				else
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