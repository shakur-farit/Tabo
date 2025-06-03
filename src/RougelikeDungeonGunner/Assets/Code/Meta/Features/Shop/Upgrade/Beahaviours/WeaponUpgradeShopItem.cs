using System.Text.RegularExpressions;
using Code.Meta.Features.Shop.WeaponUpgrade;
using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using Code.Progress.Provider;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public class WeaponUpgradeShopItem : MonoBehaviour
	{
		[SerializeField] private TextMeshProUGUI _priceText;
		[SerializeField] private TextMeshProUGUI _name;
		[SerializeField] private TextMeshProUGUI _statValueText;
		[SerializeField] private Button _buyButton;

		private WeaponUpgradeShopItemConfig _config;

		private IProgressProvider _progressProvider;
		private IWeaponUpgradeService _weaponUpgradeService;

		[Inject]
		public void Constructor(IProgressProvider progressProvider, IWeaponUpgradeService weaponUpgradeService)
		{
			_progressProvider = progressProvider;
			_weaponUpgradeService = weaponUpgradeService;
		}

		private void OnEnable() =>
			_buyButton.onClick.AddListener(Upgrade);

		public void Setup(WeaponUpgradeShopItemConfig config)
		{
			_priceText.text = config.Price.ToString();
			_name.text = FormatToName(config.TypeId);

			_config = config;

			_statValueText.text = UpdateCurrentValueText();
		}

		private string FormatToName(WeaponUpgradeShopItemTypeId typeId)
		{
			string name = typeId.ToString();

			return Regex.Replace(name, "(?<!^)([A-Z])", " $1");
		}

		private void Upgrade()
		{
			_weaponUpgradeService.Upgrade(_config);

			_statValueText.text = UpdateCurrentValueText();

			Debug.Log($"{_progressProvider.WeaponData.Accuracy}%");
			Debug.Log($"{_progressProvider.WeaponData.MinSpreadAngle} / {_progressProvider.WeaponData.MaxSpreadAngle}");
		}

		private string UpdateCurrentValueText()
		{
			switch (_config.TypeId)
			{
				case WeaponUpgradeShopItemTypeId.FireRange:
					return $"{_progressProvider.WeaponData.FireRange}";
				case WeaponUpgradeShopItemTypeId.Cooldown:
					return $"{_progressProvider.WeaponData.Cooldown}";
				case WeaponUpgradeShopItemTypeId.ReloadTime:
					return $"{_progressProvider.WeaponData.ReloadTime}";
				case WeaponUpgradeShopItemTypeId.PrechargingTime:
					return $"{_progressProvider.WeaponData.PrechargingTime}";
				case WeaponUpgradeShopItemTypeId.MagazineSize:
					return $"{_progressProvider.WeaponData.MagazineSize}";
				case WeaponUpgradeShopItemTypeId.Accuracy:
					return $"{_progressProvider.WeaponData.Accuracy}%";
				case WeaponUpgradeShopItemTypeId.EnchantSlots:
					return $"{_progressProvider.WeaponData.MaxEnchantsCount }";
				default:
					return string.Empty;
			}
		}
	}
}