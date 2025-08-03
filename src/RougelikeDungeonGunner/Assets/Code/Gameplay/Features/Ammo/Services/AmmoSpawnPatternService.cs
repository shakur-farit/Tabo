using System;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.TargetCollection;
using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Services
{
	public class AmmoSpawnPatternService : IAmmoSpawnPatternService
	{
		private readonly IAmmoFactory _factory;

		public AmmoSpawnPatternService(IAmmoFactory factory) => 
			_factory = factory;

		public void SpawnAmmoPattern(AmmoPattern pattern, AmmoTypeId ammoType,
			Vector3 origin, Vector3 forward, int producerId)
		{
			switch (pattern.PatternTypeId)
			{
				case AmmoPatternTypeId.Single:
					CreateSingle(ammoType, origin, forward, producerId);
					break;
				case AmmoPatternTypeId.Circle:
					CreateCircle(ammoType, origin, pattern.AmmoCount, forward, producerId, pattern.Raduis);
					break;
				case AmmoPatternTypeId.Triangle:
					CreateTriangle(ammoType, origin, forward, producerId);
					break;
				case AmmoPatternTypeId.Star:
					CreateStar(ammoType, origin, pattern.AmmoCount, producerId);
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(pattern.PatternTypeId), $"Unsupported pattern type: {pattern.PatternTypeId}");
			}
		}

		private void CreateSingle(AmmoTypeId ammoType, Vector3 origin, Vector3 forward, int producerId)
		{
			var ammo = _factory.CreateAmmo(ammoType, origin);
			ammo.ReplaceDirection(forward);
			ammo.AddProducerId(producerId);
			ammo.isMoving = true;
		}

		private void CreateCircle(AmmoTypeId ammoType, Vector3 origin, int count, Vector3 forward, 
			int producerId, float radius)
		{
			for (int i = 0; i < count; i++)
			{
				float angle = (360f / count) * i;
				Vector3 offset = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad),
					Mathf.Sin(angle * Mathf.Deg2Rad), 0f) * radius;

				Vector3 spawnPosition = origin + offset;

				var ammo = _factory.CreateAmmo(ammoType, spawnPosition);
				ammo.ReplaceDirection(forward.normalized);
				ammo.AddProducerId(producerId);
				ammo.isMoving = true;
			}
		}

		private void CreateTriangle(AmmoTypeId ammoType, Vector3 origin, Vector3 forward, int producerId)
		{
			Vector3[] dirs = new[]
			{
				Quaternion.Euler(0, 0, -15f) * forward,
				forward,
				Quaternion.Euler(0, 0, 15f) * forward
			};

			foreach (var dir in dirs)
			{
				var ammo = _factory.CreateAmmo(ammoType, origin);
				ammo.ReplaceDirection(dir.normalized);
				ammo.AddProducerId(producerId);
				ammo.isMoving = true;
			}
		}

		private void CreateStar(AmmoTypeId ammoType, Vector3 origin, int count, int producerId)
		{
			for (int i = 0; i < count; i++)
			{
				float angle = (360f / count) * i;
				Vector3 dir = Quaternion.Euler(0, 0, angle) * Vector3.right;

				var ammo = _factory.CreateAmmo(ammoType, origin);
				ammo.ReplaceDirection(dir.normalized);
				ammo.AddProducerId(producerId);
				ammo.isMoving = true;
			}
		}
	}
}