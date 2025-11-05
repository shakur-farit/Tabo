using Code.Gameplay.Features.Hero.Services;
using System.Collections.Generic;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponShopWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Transform _layout;
		[SerializeField] private WeaponShopUpdater _weaponShopUpdater;

		private readonly List<GameObject> _items = new();

		private IWindowService _windowService;
    private ICurrentHeroWeaponProvider _heroWeapon;

    [Inject]
		public void Constructor(IWindowService windowService, ICurrentHeroWeaponProvider heroWeapon)
		{
			Id = WindowId.WeaponShopWindow;

			_windowService = windowService;
      _heroWeapon = heroWeapon;
    }

		protected override void Initialize()
		{
			_closeButton.onClick.AddListener(Close);

			UpdateWeaponsInShop();
		}

		protected override void SubscribeUpdates() => 
			_heroWeapon.WeaponChanged += UpdateWeaponsInShop;

		protected override void UnsubscribeUpdates() => 
			_heroWeapon.WeaponChanged -= UpdateWeaponsInShop;

		private void Close() => 
			_windowService.Close(WindowId.WeaponShopWindow);

		private void UpdateWeaponsInShop() => 
			_weaponShopUpdater.UpdateWeaponsInShop(_items, _layout);
	}
}