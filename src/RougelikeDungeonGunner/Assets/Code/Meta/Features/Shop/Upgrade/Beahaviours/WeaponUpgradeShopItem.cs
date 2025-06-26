using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Code.Gameplay.Features.Effects;
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
		private IWeaponUpgrader _weaponUpgrader;
		private IWeaponStatsProvider _statsProvider;
		private IStaticDataService _staticDataService;
		private IWeaponEffectsProvider _effectsProvider;

		[Inject]
		public void Constructor(
			IProgressProvider progressProvider,
			IWeaponUpgrader weaponUpgrader,
			IWeaponStatsProvider statsProvider,
			IWeaponEffectsProvider effectsProvider,
			IStaticDataService staticDataService)
		{
			_progressProvider = progressProvider;
			_weaponUpgrader = weaponUpgrader;
			_statsProvider = statsProvider;
			_effectsProvider = effectsProvider;
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

		private string FormatToName(WeaponUpgradeTypeId typeId)
		{
			string name = typeId.ToString();

			return Regex.Replace(name, "(?<!^)([A-Z])", " $1");
		}

		private void Upgrade()
		{
			_weaponUpgrader.Upgrade(_config);

			_statValueText.text = UpdateCurrentValueText();
		}

		private string UpdateCurrentValueText()
		{
			WeaponTypeId currentWeapon = _progressProvider.HeroData.CurrentWeaponTypeId;
			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(currentWeapon);

			switch (_config.TypeId)
			{
				case WeaponUpgradeTypeId.FireRange:
					return _statsProvider.GetFireRange(weaponConfig).ToString("F2");
				case WeaponUpgradeTypeId.Cooldown:
					return _statsProvider.GetCooldown(weaponConfig).ToString("F2");
				case WeaponUpgradeTypeId.ReloadTime:
					return _statsProvider.GetReloadTime(weaponConfig).ToString("F2");
				case WeaponUpgradeTypeId.PrechargingTime:
					return _statsProvider.GetPrechargingTime(weaponConfig).ToString("F2");
				case WeaponUpgradeTypeId.MagazineSize:
					return _statsProvider.GetMagazineSize(weaponConfig).ToString();
				case WeaponUpgradeTypeId.Accuracy:
					return _statsProvider.GetAccuracy(weaponConfig).ToString("F2") + "%";
				case WeaponUpgradeTypeId.EnchantSlots:
					return _statsProvider.GetEnchantSlots(weaponConfig).ToString();
				case WeaponUpgradeTypeId.Damage:
					return VisualDamageValue(weaponConfig);
				default:
					return string.Empty;
			}
		}

		private string VisualDamageValue(WeaponConfig weaponConfig)
		{
			List<EffectSetup> effects = _effectsProvider.GetEffects(weaponConfig);
			EffectSetup damageEffect = effects.FirstOrDefault(e => e.EffectTypeId == EffectTypeId.Damage);

			if (damageEffect != null)
				 return damageEffect.Value.ToString();

			return string.Empty;
		}
	}
}