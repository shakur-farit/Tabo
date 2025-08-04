using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Services
{
	public class AmmoSpawnPatternService : IAmmoSpawnPatternService
	{
		private readonly IAmmoFactory _factory;

		public AmmoSpawnPatternService(IAmmoFactory factory) => 
			_factory = factory;

		public void SpawnAmmoPattern(AmmoPatternSetup patternSetup, AmmoTypeId ammoType,
			Vector3 origin, Vector3 forward, int producerId)
		{
			switch (patternSetup.PatternTypeId)
			{
				case AmmoPatternTypeId.Single:
					CreateSingle(ammoType, origin, forward, producerId);
					break;
				case AmmoPatternTypeId.Circle:
					CreateCircle(ammoType, origin, forward, patternSetup.AmmoCount, producerId, patternSetup.Raduis);
					break;
				case AmmoPatternTypeId.Triangle:
					CreateTriangle(ammoType, origin, forward, patternSetup.AmmoCount, producerId, patternSetup.Raduis);
					break;
				case AmmoPatternTypeId.Star:
					CreateStar(patternSetup, ammoType, origin, forward, producerId);
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(patternSetup.PatternTypeId), $"Unsupported pattern type: {patternSetup.PatternTypeId}");
			}
		}

		private void CreateSingle(AmmoTypeId ammoType, Vector3 origin, Vector3 forward, int producerId)
		{
			GameEntity ammo = _factory.CreateAmmo(ammoType, origin);
			ammo.ReplaceDirection(forward.normalized);
			ammo.AddProducerId(producerId);
			ammo.isMoving = true;
		}

		private void CreateCircle(AmmoTypeId ammoType, Vector3 origin, Vector3 forward, int count, 
			int producerId, float radius)
		{
			for (int i = 0; i < count; i++)
			{
				float angle = (360f / count) * i;
				Vector3 offset = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad),
					Mathf.Sin(angle * Mathf.Deg2Rad), 0f) * radius;

				Vector3 spawnPosition = origin + offset;

				GameEntity ammo = _factory.CreateAmmo(ammoType, spawnPosition);
				ammo.ReplaceDirection(forward.normalized);
				ammo.AddProducerId(producerId);
				ammo.isMoving = true;
			}
		}
		
		private void CreateTriangle(AmmoTypeId ammoType, Vector3 origin, Vector3 forward, int count,
			int producerId, float radius)
		{
			Vector3[] vertices = new Vector3[3];
			
			for (int i = 0; i < 3; i++)
			{
				float angle = 120f * i - 90f;
				Vector3 dir = Quaternion.Euler(0, 0, angle) * Vector3.up;
				vertices[i] = origin + dir * radius;
			}

			float sideLength = Vector3.Distance(vertices[0], vertices[1]);
			float perimeter = sideLength * 3;

			float spacing = perimeter / count;

			for (int i = 0; i < count; i++)
			{
				float distanceAlongPerimeter = spacing * i;

				int sideIndex = (int)(distanceAlongPerimeter / sideLength);
				float sidePos = (distanceAlongPerimeter % sideLength) / sideLength;

				Vector3 spawnPos = Vector3.Lerp(vertices[sideIndex], vertices[(sideIndex + 1) % 3], sidePos);

				GameEntity ammo = _factory.CreateAmmo(ammoType, spawnPos);
				ammo.ReplaceDirection(forward.normalized);
				ammo.AddProducerId(producerId);
				ammo.isMoving = true;
			}

		}

		private void CreateStar(AmmoPatternSetup setup, AmmoTypeId ammoType, 
			Vector3 origin, Vector3 forward,	int producerId)
		{
			int branches = 6;
			List<Transform> transforms = new();

			for (int b = 0; b < branches; b++)
			{
				float baseAngle = (360f / branches) * b;
				Vector3 branchDir = Quaternion.Euler(0, 0, baseAngle) * Vector3.right;

				for (int p = 0; p < setup.AmmoCount; p++)
				{
					float t = (float)p / (setup.AmmoCount - 1);
					float maxRadius = t * setup.Raduis;
					float waveOffset = Mathf.Sin(t * Mathf.PI * setup.AmmoCount) * (setup.Raduis * 0.1f);

					Vector3 offset = branchDir * (maxRadius + waveOffset);
					Vector3 spawnPos = origin + offset;

					GameEntity ammo = _factory.CreateAmmo(ammoType, spawnPos);
					ammo.ReplaceDirection(forward.normalized);
					ammo.AddProducerId(producerId);
					ammo.isMoving = true;

					transforms.Add(ammo.Transform);
				}
			}

			//CreateAmmoPattern(transforms, setup, origin);
		}

		private void CreateAmmoPattern(List<Transform> transformsList, AmmoPatternSetup setup, Vector2 center)
		{
			CreateEntity.Empty()
				.AddAmmoTransformsList(transformsList)
				.AddRotateRadius(setup.Raduis)
				.AddRotateSpeed(setup.RotateSpeed)
				.AddPatternCenter(center)
				;
		}
	}
}