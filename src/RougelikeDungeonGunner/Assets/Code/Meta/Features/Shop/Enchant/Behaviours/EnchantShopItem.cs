using Code.Common.Extensions;
using Code.Meta.Features.Shop.Enchant.Configs;
using Code.Meta.Features.Shop.Services;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Services;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.Enchant.Behaviours
{
	public class EnchantShopItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _priceText;
		[SerializeField] private Button _showEnchantBuyWindow;

		private int _price;
		private EnchantShopItemTypeId _enchantShopItemTypeId;

		private IWindowService _windowService;
		private IEnchantShopService _shopService;

		[Inject]
		public void Constructor(IWindowService windowService, IEnchantShopService shopService)
		{
			_windowService = windowService;
			_shopService = shopService;
		}

		private void Start() =>
			_showEnchantBuyWindow.onClick.AddListener(OpenEnchantBuyWindow);

		public void Setup(EnchantShopItemConfig config)
		{
			_icon.sprite = config.Sprite;
			_name.text = config.TypeId.ToDisplayName();
			_priceText.text = config.Price.ToString();
			_price = config.Price;
			_enchantShopItemTypeId = config.TypeId;
		}

		private void OpenEnchantBuyWindow()
		{
			_shopService.SetEnchantPrice(_price);
			_shopService.SetEnchantSprite(_icon.sprite);
			_shopService.SetEnchantTypeId(_enchantShopItemTypeId);

			_windowService.Open(WindowId.EnchantBuyWindow);
		}
	}
}