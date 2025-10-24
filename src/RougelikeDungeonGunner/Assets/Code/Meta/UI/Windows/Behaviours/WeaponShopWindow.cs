using Code.Gameplay.Features.Hero.Services;
using Code.Meta.UI.Windows.Service;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponShopWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Transform _layout;

		private readonly List<GameObject> _items = new();

		private IWindowService _windowService;
    private ICurrentHeroWeaponProvider _heroWeapon;
    private IWeaponShopUpdater _updater;


    [Inject]
		public void Constructor(IWindowService windowService, ICurrentHeroWeaponProvider heroWeapon, IWeaponShopUpdater updater)
		{
			Id = WindowId.WeaponShopWindow;

			_windowService = windowService;
      _heroWeapon = heroWeapon;
      _updater = updater;
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
      _updater.UpdateWeaponsInShop(_items,_layout);
  }
}