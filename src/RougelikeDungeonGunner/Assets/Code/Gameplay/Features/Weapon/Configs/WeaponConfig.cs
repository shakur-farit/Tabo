using System;
using System.Collections.Generic;
using Assets.Code.Gameplay.Features.Ammo;
using Assets.Code.Gameplay.Features.AmmoPattern;
using Assets.Code.Gameplay.Features.Collection;
using Assets.Code.Gameplay.Features.Effects;
using Assets.Code.Gameplay.Features.SpecialEffect;
using Assets.Code.Gameplay.Features.Statuses;
using Assets.Code.Infrastructure.View;
using Assets.Code.Meta.Features.Shop.Upgrade;
using Assets.Code.Meta.Features.Shop.WeaponStatUIEntry;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Weapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Config", fileName = "WeaponConfig")]
	public class WeaponConfig : ScriptableObject
	{
		public WeaponTypeId TypeId;
		public AmmoTypeId AmmoTypeId;
		public SpecialEffectTypeId SpecialEffectTypeId;
		public AmmoPatternSetup AmmoPatternSetup;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		public Vector2 FirePosition;

		public WeaponStats Stats;

		public CollisionCastSetup CastSetup;

		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;

		public List<WeaponAvailableUpgrade> AvailableUpgrades;

		public List<WeaponStatUIEntry> StatsUIEntry;
	}

	[Serializable]
	public class WeaponStats
	{
		public bool isInfinityAmmo;
		[Range(0f, 100f)] public float FireRange;
		[Range(0f, 100f)] public float Cooldown;
		[Range(0f, 100f)] public float ReloadTime;
		[Range(0f, 100f)] public float PrechargingTime;
		[Range(0, 100)] public int MagazineSize;
		[Range(0, 100)] public int Pierce = 1;
		[Range(0, 10)] public int PelletCount = 1;
		[Tooltip("In percents")]
		[Range(0f, 100f)] public float Accuracy;
		[Range(0, 5)] public int EnchantSlots;
	}

	[Serializable]
	public class WeaponAvailableUpgrade
	{
		public WeaponUpgradeTypeId UpgradeType;
	}

	[Serializable]
	public class WeaponStatUIEntry
	{
		public WeaponStatUIEntryTypeId StatUIEntryType;
	}

	[Serializable]
	public class AmmoPatternSetup
	{
		public AmmoPatternTypeId PatternTypeId;
		[Range(1, 50)] public int AmmoCount;
		[Range(0.1f, 10f)] public float Raduis;
		[Range(0f, 360f)] public float RotationSpeed;
		[Range(0f, 50f)] public float MovementSpeed;
		[Range(0, 10)] public int Branches;
	}
}