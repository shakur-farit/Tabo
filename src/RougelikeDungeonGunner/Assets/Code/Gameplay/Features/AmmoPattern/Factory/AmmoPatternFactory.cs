using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	public class AmmoPatternFactory : IAmmoPatternFactory
	{
		public GameEntity CreatePattern(AmmoPatternSetup patternSetup, AmmoTypeId ammoType,
			Vector3 origin, Vector3 forward)
		{
			switch (patternSetup.PatternTypeId)
			{
				case AmmoPatternTypeId.Single:
					return CreateSingle(patternSetup, ammoType, origin, forward);
				case AmmoPatternTypeId.Circle:
					return CreateCircle(patternSetup, ammoType, origin, forward);
				case AmmoPatternTypeId.Triangle:
					return CreateTriangle(patternSetup, ammoType, origin, forward);
				case AmmoPatternTypeId.Star:
					return CreateStar(patternSetup, ammoType, origin, forward);
				default:
					throw new ArgumentOutOfRangeException(nameof(patternSetup.PatternTypeId), $"Unsupported pattern type: {patternSetup.PatternTypeId}");
			}
		}

		private GameEntity CreateStar(AmmoPatternSetup patternSetup, AmmoTypeId ammoType, Vector3 origin, Vector3 forward) =>
			CreatePatternEntity(patternSetup, ammoType, origin, forward)
				.With(x => x.isStarPattern = true);

		private GameEntity CreateTriangle(AmmoPatternSetup patternSetup, AmmoTypeId ammoType, Vector3 origin, Vector3 forward) =>
			CreatePatternEntity(patternSetup, ammoType, origin, forward)
				.With(x => x.isTrianglePattern = true);

		private GameEntity CreateCircle(AmmoPatternSetup patternSetup, AmmoTypeId ammoType, Vector3 origin, Vector3 forward) =>
			CreatePatternEntity(patternSetup, ammoType, origin, forward)
				.With(x => x.isCirclePattern = true);

		private GameEntity CreateSingle(AmmoPatternSetup ammoPatternSetup, AmmoTypeId ammoType, Vector3 origin, Vector3 forward) => 
			CreatePatternEntity(ammoPatternSetup, ammoType, origin, forward)
				.With(x => x.isSinglePattern = true);

		private GameEntity CreatePatternEntity(AmmoPatternSetup ammoPatternSetup, AmmoTypeId ammoTypeId, Vector3 origin, Vector3 forward) =>
			CreateEntity.Empty()
				.AddAmmoPatternSetup(ammoPatternSetup)
				.AddAmmoTypeId(ammoTypeId)
				.AddPatternCenter(origin)
				.AddDirection(forward)
				.AddPatternAmmoCount(ammoPatternSetup.AmmoCount)
				.AddRotateRadius(ammoPatternSetup.Raduis)
				.AddRotateSpeed(ammoPatternSetup.RotateSpeed)
				.With(x => x.isAmmoPattern = true);
	}
}