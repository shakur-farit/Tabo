using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Config;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Factory
{
	public class AmmoFactory : IAmmoFactory
	{
		private const int TargetsBufferSize = 16;

		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public AmmoFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateAmmo(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			switch (ammoTypeId)
			{
				case AmmoTypeId.PistolBullet:
					return CreatePistolBullet(ammoTypeId, level, at);
				case AmmoTypeId.RevolverBullet:
					return CreateRevolverBullet(ammoTypeId, level, at);
				case AmmoTypeId.ShotgunBullet:
					return CreateShotgunBullet(ammoTypeId, level, at);
				case AmmoTypeId.AutomaticPistolBullet:
					return CreateAutomaticPistolBullet(ammoTypeId, level, at);
				case AmmoTypeId.MachinegunBullet:
					return CreateMachinegunBullet(ammoTypeId, level, at);
				case AmmoTypeId.SniperBullet:
					return CreateSniperBullet(ammoTypeId, level, at);
				case AmmoTypeId.PlasmaBolt:
					return CreatePlasmaBolt(ammoTypeId, level, at);
				case AmmoTypeId.LaserBolt:
					return CreateLaserBolt(ammoTypeId, level, at);
				case AmmoTypeId.RocketMissile:
					return CreateRocketMissile(ammoTypeId, level, at);
			}

			throw new Exception($"Ammo for {ammoTypeId} type was not found");

		}

		private GameEntity CreatePistolBullet(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isPistolBullet = true)
				;
		}

		private GameEntity CreateRevolverBullet(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isRevolverBullet = true)
				;
		}

		private GameEntity CreateShotgunBullet(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isShotgunBullet = true)
				;
		}

		private GameEntity CreateAutomaticPistolBullet(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isAutomaticPistolBullet = true)
				;
		}
		private GameEntity CreateMachinegunBullet(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isMachinegunBullet = true)
				;
		}

		private GameEntity CreateSniperBullet(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isSniperBullet = true)
				;
		}

		private GameEntity CreatePlasmaBolt(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isPlasmaBolt = true)
				;
		}

		private GameEntity CreateLaserBolt(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isLaserBolt = true)
				;
		}

		private GameEntity CreateRocketMissile(AmmoTypeId ammoTypeId, int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoLevel ammoLevel = _staticDataService.GetAmmoLevel(ammoTypeId, level);

			return CreateAmmoEntity(ammoTypeId, at, ammo, ammoLevel)
					.With(x => x.isRocketMissile = true)
				;
		}

		private GameEntity CreateAmmoEntity(AmmoTypeId ammoTypeId, Vector3 at, AmmoConfig ammo, AmmoLevel ammoLevel)
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddAmmoTypeId(ammoTypeId)
					.AddViewPrefab(ammo.ViewPrefab)
					.AddSpeed(ammoLevel.Speed)
					.AddTargetLimit(ammoLevel.Pierce)
					.AddRadius(ammoLevel.ContactRadius)
					.AddEffectSetups(ammoLevel.EffectSetups)
					.AddStatusSetups(ammoLevel.StatusSetups)
					.AddTargetsBuffer(new List<int>(TargetsBufferSize))
					.AddProcessedTargets(new List<int>(TargetsBufferSize))
					.AddLayerMask(CollisionLayer.Enemy.AsMask())
					.With(x => x.isAmmo = true)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isCollectTargetsContinuously = true)
				;
		}
	}
}