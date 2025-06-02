using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using System.Collections.Generic;
using Code.Gameplay.Features.Weapon.Configs;

namespace Code.Progress.Data
{
	public class WeaponData
	{
		public bool isInfinityAmmo;
		public float FireRange;
		public float Cooldown;
		public float ReloadTime;
		public float PrechargingTime;
		public int MagazineSize;
		public int PelletCount;
		public float MinSpreadAngle;
		public float MaxSpreadAngle;
		public int MaxEnchantsCount;

		public List<EffectSetup> EffectSetups = new();
		public List<StatusSetup> StatusSetups = new();

		public void ResetWeaponData(WeaponConfig config)
		{
			isInfinityAmmo = config.isInfinityAmmo;
			FireRange = config.FireRange;
			Cooldown = config.Cooldown;
			ReloadTime = config.ReloadTime;
			PrechargingTime = config.PrechargingTime;
			MagazineSize = config.MagazineSize;
			PelletCount = config.PelletCount;
			MinSpreadAngle = config.MinSpreadAngle;
			MaxSpreadAngle = config.MaxSpreadAngle;
			MaxEnchantsCount = config.MaxEnchantsCount;

			EffectSetups = config.EffectSetups;
			StatusSetups = config.StatusSetups;
		}
	}
}