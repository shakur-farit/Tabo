using Code.Common.Extensions;
using Code.Gameplay.Features.Weapon;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponShopItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _priceText;
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private Button _buyItemButton;

		private WeaponTypeId _weaponToBuy;
		private int _price;

		private IWindowService _windowService;
		private IWeaponShopService _shopService;

		public WeaponTypeId WeaponToBuy => _weaponToBuy;

		[Inject]
		public void Constructor(IWindowService windowService, IWeaponShopService shopService)
		{
			_windowService = windowService;
			_shopService = shopService;
		}

		private void OnEnable() => 
			_buyItemButton.onClick.AddListener(OpenWeaponBuyDialogWindow);

		public void Setup(WeaponShopItemConfig config)
		{
			_icon.sprite = config.Sprite;
			_priceText.text = config.Price.ToString();
			_price = config.Price;
			_name.text = config.TypeId.ToDisplayName();
			_weaponToBuy = config.WeaponTypeId;
		}

		private void OpenWeaponBuyDialogWindow()
		{
			_shopService.SetWeaponSprite(_icon.sprite);
			_shopService.SetWeaponPrice(_price);
			_shopService.SetWeaponTypeId(_weaponToBuy);

			_windowService.Open(WindowId.WeaponBuyDialogWindow);
		}
	}
}