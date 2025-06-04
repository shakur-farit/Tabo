using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using System.Collections.Generic;
using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;
using UnityEngine.Rendering;

namespace Code.Progress.Data
{
	public class WeaponData
	{
		private const float MaxSpread = 200f;


		public float FireRange;
		public float Cooldown;
		public float ReloadTime;
		public float PrechargingTime;
		public int MagazineSize;
		public float MinSpreadAngle;
		public float MaxSpreadAngle;
		public int MaxEnchantsCount;

		public List<EffectSetup> EffectSetups = new();
		public List<StatusSetup> StatusSetups = new();

		public float Accuracy
		{
			get
			{
				float spread = Mathf.Abs(MinSpreadAngle) + Mathf.Abs(MaxSpreadAngle);
				float accuracy = 1f - Mathf.Clamp01(spread / MaxSpread);
				return accuracy * 100f;
			}
			set
			{
				float clampedAccuracy = Mathf.Clamp(value, 0f, 100f) / 100f;
				float spread = MaxSpread * (1f - clampedAccuracy);
				float halfSpread = spread * 0.5f;

				MinSpreadAngle = -halfSpread;
				MaxSpreadAngle = halfSpread;
			}
		}

		public void ResetWeaponData(WeaponConfig config)
		{
			FireRange = config.FireRange;
			Cooldown = config.Cooldown;
			ReloadTime = config.ReloadTime;
			PrechargingTime = config.PrechargingTime;
			MagazineSize = config.MagazineSize;
			MinSpreadAngle = config.MinSpreadAngle;
			MaxSpreadAngle = config.MaxSpreadAngle;
			MaxEnchantsCount = config.MaxEnchantsCount;

			EffectSetups = config.EffectSetups;
			StatusSetups = config.StatusSetups;
		}
	}
}