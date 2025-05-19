using System.Text.RegularExpressions;
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

		private WeaponShopItemConfig _weaponToBuyConfig;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;

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
			_name.text = FormatToName(config.TypeId);

			_weaponToBuyConfig = config;
		}

		private string FormatToName(WeaponShopItemTypeId typeId)
		{
			string name = typeId.ToString();

			return Regex.Replace(name, "(?<!^)([A-Z])", " $1");
		}

		private void OpenWeaponBuyDialogWindow()
		{
			_windowService.Open(WindowId.WeaponBuyDialogWindow);

			_progressProvider.ShopData.WeaponToBuyConfig = _weaponToBuyConfig;
		}
	}
}