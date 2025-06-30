using System;
using System.Linq;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Factory;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours
{
	public class StatsUIHolder : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

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
		}

		public void CreateStatUIEntryItem(WeaponStatUIEntryTypeId id, WeaponConfig weaponConfig)
		{
			switch (id)
			{
				case WeaponStatUIEntryTypeId.Pierce:
					CreatePierceUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.Damage:
					CreateDamageUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.Accuracy:
					CreateAccuracyUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.EnchantSlots:
					CreateEnchantSlotsUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.Cooldown:
					CreateCooldownUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.FireRange:
					CreateFireRangeUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.InfinityAmmo:
					CreateInfinityAmmoUiEntry(id, _holder);
					break;
				case WeaponStatUIEntryTypeId.PrechargingTime:
					CreatePrechargingTimeUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.ReloadTime:
					CreateReloadTimeUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.PelletCount:
					CreatePelletCountUiEntry(id, _holder, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.MagazineSize:
					CreateMagazineSizeUiEntry(id, _holder, weaponConfig);
					break;
				default:
					throw new Exception($"UI entry with type id {id} does not exist");
			}
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
	}
}