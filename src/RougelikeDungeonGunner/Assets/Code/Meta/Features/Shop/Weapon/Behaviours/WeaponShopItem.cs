using Code.Common.Extensions;
using Code.Gameplay.Features.Weapon;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponShopItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _price;
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private Button _buyItemButton;

		private WeaponShopItemConfig _shopItemConfig;
		private WeaponTypeId _weaponToBuy;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;

		public WeaponTypeId WeaponToBuy => _weaponToBuy;

		[Inject]
		public void Constructor(IWindowService windowService, IProgressProvider progressProvider)
		{
			_windowService = windowService;
			_progressProvider = progressProvider;
		}

		private void OnEnable() => 
			_buyItemButton.onClick.AddListener(OpenWeaponBuyDialogWindow);

		public void Setup(WeaponShopItemConfig config)
		{
			_icon.sprite = config.Sprite;
			_price.text = config.Price.ToString();
			_name.text = config.TypeId.ToDisplayName();

			_shopItemConfig = config;
			_weaponToBuy = config.WeaponTypeId;
		}

		private void OpenWeaponBuyDialogWindow()
		{
			_windowService.Open(WindowId.WeaponBuyDialogWindow);

			_progressProvider.ShopData.WeaponToBuyConfig = _shopItemConfig;
		}
	}
}