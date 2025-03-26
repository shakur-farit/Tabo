using System;

namespace Code.Gameplay.Features.Weapon.Configs
{
	[Serializable]
	public class WeaponLevel
	{
		public float FireRange;
		public float Cooldown;
		public float ReloadTime;
		public float PrechargeTime;
		public int MagazineSize;
		public int PelletCount = 1;
		public float MinSpreadAngle;
		public float MaxSpreadAngle;
	}
}