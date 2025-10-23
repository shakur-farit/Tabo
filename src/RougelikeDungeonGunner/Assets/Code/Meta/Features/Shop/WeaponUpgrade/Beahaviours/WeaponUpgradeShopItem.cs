using System;
using System.Collections.Generic;
using System.Linq;
using Code.Common.Extensions;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Meta.Features.Shop.Upgrade.Services;
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

		private Dictionary<WeaponUpgradeTypeId, Func<WeaponConfig, string>> _valueResolvers;

		private WeaponUpgradeShopItemConfig _config;

		private IWeaponUpgrader _weaponUpgrader;
		private IWeaponStatsProvider _statsProvider;
		private IStaticDataService _staticDataService;
		private IWeaponEffectsProvider _effectsProvider;
		private ICurrentHeroWeaponProvider _heroWeapon;

		[Inject]
		public void Constructor(
			IWeaponUpgrader weaponUpgrader,
			IWeaponStatsProvider statsProvider,
			ICurrentHeroWeaponProvider heroWeapon,
			IWeaponEffectsProvider effectsProvider,
			IStaticDataService staticDataService)
		{
			_weaponUpgrader = weaponUpgrader;
			_statsProvider = statsProvider;
			_heroWeapon = heroWeapon;
			_effectsProvider = effectsProvider;
			_staticDataService = staticDataService;

			InitializeResolvers();
		}

		private void OnEnable() =>
			_buyButton.onClick.AddListener(Upgrade);

		public void Setup(WeaponUpgradeShopItemConfig config)
		{
			_config = config;

			_priceText.text = config.Price.ToString();
			_name.text = config.TypeId.ToDisplayName();

			_statValueText.text = UpdateCurrentValueText();
		}

		private void Upgrade()
		{
			_weaponUpgrader.Upgrade(_config);

			_statValueText.text = UpdateCurrentValueText();
		}

		private string UpdateCurrentValueText()
		{
			WeaponTypeId currentWeapon = _heroWeapon.CurrentWeaponTypeId;
			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(currentWeapon);

			if (_valueResolvers.TryGetValue(_config.TypeId, out var resolver))
				return resolver.Invoke(weaponConfig);

			Debug.LogWarning($"No resolver found for upgrade type {_config.TypeId}");
			return string.Empty;
		}

		private void InitializeResolvers()
		{
			_valueResolvers = new Dictionary<WeaponUpgradeTypeId, Func<WeaponConfig, string>>
			{
				[WeaponUpgradeTypeId.FireRange] = c => _statsProvider.GetFireRange(c).ToString("F2"),
				[WeaponUpgradeTypeId.Cooldown] = c => _statsProvider.GetCooldown(c).ToString("F2"),
				[WeaponUpgradeTypeId.ReloadTime] = c => _statsProvider.GetReloadTime(c).ToString("F2"),
				[WeaponUpgradeTypeId.PrechargingTime] = c => _statsProvider.GetPrechargingTime(c).ToString("F2"),
				[WeaponUpgradeTypeId.MagazineSize] = c => _statsProvider.GetMagazineSize(c).ToString(),
				[WeaponUpgradeTypeId.Accuracy] = c => _statsProvider.GetAccuracy(c).ToString("F2") + "%",
				[WeaponUpgradeTypeId.EnchantSlots] = c => _statsProvider.GetEnchantSlots(c).ToString(),
				[WeaponUpgradeTypeId.Pierce] = c => _statsProvider.GetPierce(c).ToString(),
				[WeaponUpgradeTypeId.Damage] = VisualDamageValue,
				[WeaponUpgradeTypeId.MaxAmmoCount] = c => _statsProvider.GetMaxAmmoCount(c).ToString()
			};
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