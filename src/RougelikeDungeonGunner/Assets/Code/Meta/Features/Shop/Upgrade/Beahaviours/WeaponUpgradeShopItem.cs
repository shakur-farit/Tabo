using System.Text.RegularExpressions;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Progress.Provider;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.Features.Shop.Upgrade.Beahaviours
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
		private IWeaponStatsProvider _statsProvider;
		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(
			IProgressProvider progressProvider, 
			IWeaponUpgradeService weaponUpgradeService,
			IWeaponStatsProvider statsProvider,
			IStaticDataService staticDataService)
		{
			_progressProvider = progressProvider;
			_weaponUpgradeService = weaponUpgradeService;
			_statsProvider = statsProvider;
			_staticDataService = staticDataService;
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
		}

		private string UpdateCurrentValueText()
		{
			WeaponTypeId currentWeapon = _progressProvider.HeroData.CurrentWeaponTypeId;
			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(currentWeapon);

			switch (_config.TypeId)
			{
				case WeaponUpgradeShopItemTypeId.FireRange:
					return _statsProvider.GetFireRange(weaponConfig).ToString();
				default:
					return string.Empty;
			}
		}
	}
}