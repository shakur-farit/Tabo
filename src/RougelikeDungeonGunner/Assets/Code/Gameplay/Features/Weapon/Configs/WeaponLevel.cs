using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using System;
using System.Collections.Generic;

namespace Code.Gameplay.Features.Weapon.Configs
{
	[Serializable]
	public class WeaponLevel
	{
		public bool isInfinityAmmo;
		public float FireRange;
		public float Cooldown;
		public float ReloadTime;
		public float PrechargeTime;
		public int MagazineSize;
		public int PelletCount = 1;
		public float MinSpreadAngle;
		public float MaxSpreadAngle;

		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;
	}
}