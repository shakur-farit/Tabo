using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Factory;
using Code.Meta.Features.Shop.WeaponUpgrade.Services;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours
{
	public class WeaponStatsUIHolder : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private Dictionary<WeaponStatUIEntryTypeId, Action<WeaponConfig>> _createActions;

		private IWeaponStatUIEntryItemFactory _statUIEntryFactory;
		private IWeaponStatsProvider _statsProvider;
		private IWeaponEffectsProvider _effectsProvider;

		[Inject]
		public void Constructor(
			IWeaponStatUIEntryItemFactory statUIEntryItemFactory,
			IWeaponStatsProvider statsProvider,
			IWeaponEffectsProvider effectsProvider)
		{
			_statUIEntryFactory = statUIEntryItemFactory;
			_statsProvider = statsProvider;
			_effectsProvider = effectsProvider;

			_createActions = new Dictionary<WeaponStatUIEntryTypeId, Action<WeaponConfig>>
			{
				[WeaponStatUIEntryTypeId.Pierce] =
					config => CreatePierceUiEntry(WeaponStatUIEntryTypeId.Pierce, _holder, config),
				[WeaponStatUIEntryTypeId.Damage] =
					config => CreateDamageUiEntry(WeaponStatUIEntryTypeId.Damage, _holder, config),
				[WeaponStatUIEntryTypeId.Accuracy] =
					config => CreateAccuracyUiEntry(WeaponStatUIEntryTypeId.Accuracy, _holder, config),
				[WeaponStatUIEntryTypeId.EnchantSlots] = 
          config => CreateEnchantSlotsUiEntry(WeaponStatUIEntryTypeId.EnchantSlots, _holder, config),
				[WeaponStatUIEntryTypeId.Cooldown] =
					config => CreateCooldownUiEntry(WeaponStatUIEntryTypeId.Cooldown, _holder, config),
				[WeaponStatUIEntryTypeId.FireRange] =
					config => CreateFireRangeUiEntry(WeaponStatUIEntryTypeId.FireRange, _holder, config),
				[WeaponStatUIEntryTypeId.InfinityAmmo] =
					_ => CreateInfinityAmmoUiEntry(WeaponStatUIEntryTypeId.InfinityAmmo, _holder),
				[WeaponStatUIEntryTypeId.PrechargingTime] = 
          config => CreatePrechargingTimeUiEntry(WeaponStatUIEntryTypeId.PrechargingTime, _holder, config),
				[WeaponStatUIEntryTypeId.ReloadTime] = 
          config => CreateReloadTimeUiEntry(WeaponStatUIEntryTypeId.ReloadTime, _holder, config),
				[WeaponStatUIEntryTypeId.PelletCount] =
          config => CreatePelletCountUiEntry(WeaponStatUIEntryTypeId.PelletCount, _holder, config),
				[WeaponStatUIEntryTypeId.MagazineSize] = 
          config => CreateMagazineSizeUiEntry(WeaponStatUIEntryTypeId.MagazineSize, _holder, config),
				[WeaponStatUIEntryTypeId.MaxAmmoCount] = 
          config => CreateMaxAmmoCountUiEntry(WeaponStatUIEntryTypeId.MaxAmmoCount, _holder, config)
			};
		}

		public void CreateStatUIEntryItem(WeaponStatUIEntryTypeId id, WeaponConfig weaponConfig)
		{
			if (_createActions.TryGetValue(id, out Action<WeaponConfig> action))
				action.Invoke(weaponConfig);
			else
				throw new Exception($"UI entry with type id {id} does not exist");
		}

		private void CreateAccuracyUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetAccuracy(weaponConfig) + "%");

		private void CreateEnchantSlotsUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetEnchantSlots(weaponConfig).ToString());

		private void CreateCooldownUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetCooldown(weaponConfig).ToString());

		private void CreateFireRangeUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetFireRange(weaponConfig).ToString());

		private void CreateInfinityAmmoUiEntry(WeaponStatUIEntryTypeId id, Transform parent) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, string.Empty);

		private void CreatePrechargingTimeUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetPrechargingTime(weaponConfig).ToString());

		private void CreateReloadTimeUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetReloadTime(weaponConfig).ToString());

		private void CreatePelletCountUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.PelletCount.ToString());

		private void CreateMagazineSizeUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetMagazineSize(weaponConfig).ToString());

		private void CreatePierceUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetPierce(weaponConfig).ToString());

		private void CreateDamageUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig)
		{
			float damage = _effectsProvider.GetEffects(weaponConfig)
				.FirstOrDefault(e => e.EffectTypeId == EffectTypeId.Damage)?.Value ?? 0f;

			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, damage.ToString());
		}

		private void CreateMaxAmmoCountUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, _statsProvider.GetMaxAmmoCount(weaponConfig).ToString());
  }
}