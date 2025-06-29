using System;
using System.Linq;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.Weapon.Configs
{
	public class WeaponStatUIEntryItemFactory : IWeaponStatUIEntryItemFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public WeaponStatUIEntryItemFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public WeaponStatUIEntryItem CreateStatUIEntryItem(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig)
		{
			WeaponStatUIEntryConfig config = _staticDataService.GetWeaponStatUIEntryItemConfig(id);

			switch (id)
			{
				case WeaponStatUIEntryTypeId.Pierce:
					return CreatePierceUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.Damage:
					return CreateDamageUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.Accuracy:
					return CreateAccuracyUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.EnchantSlots:
					return CreateEnchantSlotsUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.Cooldown:
					return CreateCooldownUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.FireRange:
					return CreateFireRangeUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.InfinityAmmo:
					return CreateInfinityAmmoUiEntry(config, parent);
				case WeaponStatUIEntryTypeId.PrechargingTime:
					return CreatePrechargingTimeUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.ReloadTime:
					return CreateReloadTimeUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.PelletCount:
					return CreatePelletCountUiEntry(config, parent, weaponConfig);
				case WeaponStatUIEntryTypeId.MagazineSize:
					return CreateMagazineSizeUiEntry(config, parent, weaponConfig);
			}

			throw new Exception($"UI entry with type id {config.TypeId} does not exist");
		}

		private WeaponStatUIEntryItem CreateAccuracyUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig) =>
			CreateUiEntry(config, parent, weaponConfig.Stats.Accuracy + "%");

		private WeaponStatUIEntryItem CreateEnchantSlotsUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig) => 
			CreateUiEntry(config, parent, weaponConfig.Stats.EnchantSlots.ToString());

		private WeaponStatUIEntryItem CreateCooldownUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig) => 
			CreateUiEntry(config, parent, weaponConfig.Stats.Cooldown.ToString());

		private WeaponStatUIEntryItem CreateFireRangeUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig) =>
			CreateUiEntry(config, parent, weaponConfig.Stats.FireRange.ToString());

		private WeaponStatUIEntryItem CreateInfinityAmmoUiEntry(WeaponStatUIEntryConfig config, Transform parent) => 
			CreateUiEntry(config, parent, string.Empty);

		private WeaponStatUIEntryItem CreatePrechargingTimeUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig) =>
			CreateUiEntry(config, parent, weaponConfig.Stats.PrechargingTime.ToString());

		private WeaponStatUIEntryItem CreateReloadTimeUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig) => 
			CreateUiEntry(config, parent, weaponConfig.Stats.ReloadTime.ToString());

		private WeaponStatUIEntryItem CreatePelletCountUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig) => 
			CreateUiEntry(config, parent, weaponConfig.Stats.PelletCount.ToString());

		private WeaponStatUIEntryItem CreateMagazineSizeUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig) =>
			CreateUiEntry(config, parent, weaponConfig.Stats.MagazineSize.ToString());

		private WeaponStatUIEntryItem CreatePierceUiEntry(WeaponStatUIEntryConfig config, Transform parent,
			WeaponConfig weaponConfig) =>
			CreateUiEntry(config, parent, weaponConfig.Stats.Pierce.ToString());

		private WeaponStatUIEntryItem CreateDamageUiEntry(WeaponStatUIEntryConfig config, Transform parent, 
			WeaponConfig weaponConfig)
		{
			 float damage= weaponConfig
				.EffectSetups
				.FirstOrDefault(e => e.EffectTypeId == EffectTypeId.Damage)?.Value ?? 0f;

			return CreateUiEntry(config, parent, damage.ToString());
			
		}

		public WeaponStatUIEntryItem CreateUiEntry(WeaponStatUIEntryConfig config, Transform parent,
			string valueText)
		{
			WeaponStatUIEntryItem item = _instantiator
				.InstantiatePrefabForComponent<WeaponStatUIEntryItem>(config.ViewPrefab, parent);

			item.Setup(config.TypeId, valueText);

			return item;
		}
	}
}