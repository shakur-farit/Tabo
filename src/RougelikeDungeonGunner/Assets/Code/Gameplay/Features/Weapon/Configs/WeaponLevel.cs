using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Configs
{
	[Serializable]
	public class WeaponLevel
	{
		public bool isInfinityAmmo;
		[Range(0f, 100f)] public float FireRange;
		[Range(0f, 100f)] public float Cooldown;
		[Range(0f, 100f)] public float ReloadTime;
		[Range(0f, 100f)] public float PrechargeTime;
		[Range(0, 100)] public int MagazineSize;
		[Range(0, 10)] public int PelletCount = 1;
		[Range(0f, 100f)] public float MinSpreadAngle;
		[Range(0f, 100f)] public float MaxSpreadAngle;
		[Range(0, 10)] public int MaxEnchantsCount;

		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;
	}
}