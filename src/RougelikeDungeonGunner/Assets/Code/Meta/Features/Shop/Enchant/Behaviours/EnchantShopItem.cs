using Code.Common.Extensions;
using Code.Meta.Features.Shop.Enchant.Configs;
using Code.Meta.Features.Shop.Services;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.Enchant.Behaviours
{
	public class EnchantShopItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _priceText;
		[SerializeField] private Button _showEnchantStatsButton;

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
			_showEnchantStatsButton.onClick.AddListener(ShowEnchantStats);

		public void Setup(EnchantShopItemConfig config)
		{
			_icon.sprite = config.Sprite;
			_name.text = config.TypeId.ToDisplayName();
			_priceText.text = config.Price.ToString();
			_price = config.Price;
			_enchantShopItemTypeId = config.TypeId;
		}

		private void ShowEnchantStats()
		{
			_shopService.SetEnchantPrice(_price);
			_shopService.SetEnchantSprite(_icon.sprite);
			_shopService.SetEnchantTypeId(_enchantShopItemTypeId);

			_windowService.Open(WindowId.EnchantBuyWindow);
		}
	}
}