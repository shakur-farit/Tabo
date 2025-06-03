using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Config", fileName = "WeaponConfig")]
	public class WeaponConfig : ScriptableObject
	{
		public WeaponTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		public Vector2 FirePosition;

		public bool isInfinityAmmo;
		[Range(0f, 100f)] public float FireRange;
		[Range(0f, 100f)] public float Cooldown;
		[Range(0f, 100f)] public float ReloadTime;
		[Range(0f, 100f)] public float PrechargingTime;
		[Range(0, 100)] public int MagazineSize;
		[Range(0, 10)] public int PelletCount = 1;
		[Range(-100f, 100f)] public float MinSpreadAngle;
		[Range(-100f, 100f)] public float MaxSpreadAngle;
		[Range(0, 10)] public int MaxEnchantsCount;

		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;

		private void OnValidate()
		{
			if(MinSpreadAngle > MaxSpreadAngle)
				MaxSpreadAngle = MinSpreadAngle;
		}
	}
}