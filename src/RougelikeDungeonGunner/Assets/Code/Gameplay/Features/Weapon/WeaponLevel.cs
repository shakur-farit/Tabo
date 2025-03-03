using System;

namespace Code.Gameplay.Features.Weapon
{
	[Serializable]
	public class WeaponLevel
	{
		public float Range;
		public float Cooldown;
		public float ReloadTime;
		public int MagazineSize;
	}
}