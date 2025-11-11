using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Aura;
using Code.Gameplay.Features.Collection;
using Code.Gameplay.Features.Weapon;
using Code.Infrastructure.View;
using Code.Meta.Features.Information.HeroInformation;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Hero Config", fileName = "HeroConfig")]
	public class HeroConfig : ScriptableObject
	{
		public HeroTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public RuntimeAnimatorController AnimatorController;
		public Sprite HandSprite;
		public Sprite ShopIcon;
		public WeaponTypeId StartWeapon;
		public AuraTypeId StartAura;
		[Range(1, 100)] public int CurrentHp;
		[Range(1, 100)] public int MaxHp;
		[Range(1, 100)] public int MovementSpeed;
		[Range(0, 100)] public float LootPickupRadius;
		[Range(0, 100)] public float DestroyableCollidingRadius;

		public CollisionCastSetup CastSetup;
		public List<HeroStatUIEntry> StatsUIEntry;

		private void OnValidate()
		{
			if (CurrentHp > MaxHp)
				MaxHp = CurrentHp;
		}
	}

	[Serializable]
	public class HeroStatUIEntry
	{
		public HeroStatUIEntryTypeId StatUIEntryType;
	}
}