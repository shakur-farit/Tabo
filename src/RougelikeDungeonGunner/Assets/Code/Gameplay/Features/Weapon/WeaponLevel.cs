using System;

namespace Code.Gameplay.Features.Weapon
{
	[Serializable]
	public class WeaponLevel
	{
		public float FireRange;
		public float Cooldown;
		public float ReloadTime;
		public int MagazineSize;
	}
}