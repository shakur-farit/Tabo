using Code.Common.Extensions;
using Code.Gameplay.Features.Statuses;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Configs
{
	public class EnchantShopItem : MonoBehaviour
	{
		[SerializeField] private Image _icon;
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _price;
		[SerializeField] private Button _showEnchantStatsButton;

		private StatusSetup _enchant;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private EnchantShopItemConfig _config;

		[Inject]
		public void Constructor(IWindowService windowService, IProgressProvider progressProvider)
		{
			_windowService = windowService;
			_progressProvider = progressProvider;
		}

		private void Start() =>
			_showEnchantStatsButton.onClick.AddListener(ShowEnchantStats);

		public void Setup(EnchantShopItemConfig config)
		{
			_icon.sprite = config.Sprite;
			_name.text = config.TypeId.ToDisplayName();
			_price.text = config.Price.ToString();
			_config = config;

			_progressProvider.ShopData.EnchantToBuyConfig = config;
		}

		private void ShowEnchantStats()
		{
			_progressProvider.ShopData.EnchantToBuyConfig = _config;

			_windowService.Open(WindowId.EnchantBuyDialogWindow);
		}
	}
}