using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using Code.Meta.Features.Shop.Upgrade.Services;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Factory
{
	public class AmmoFactory : IAmmoFactory
	{
		private const int TargetsBufferSize = 16;

		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;
		private readonly IWeaponStatsProvider _weaponStatsProvider;

		public AmmoFactory(
			IIdentifierService identifier,
			IStaticDataService staticDataService,
			IWeaponStatsProvider weaponStatsProvider)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
			_weaponStatsProvider = weaponStatsProvider;
		}

		public GameEntity CreateAmmo(AmmoTypeId ammoTypeId, Vector3 at)
		{
			switch (ammoTypeId)
			{
				case AmmoTypeId.Light:
					return CreateLightBullet(ammoTypeId, at);
				case AmmoTypeId.Rifle:
					return CreateRifleBullet(ammoTypeId, at);
				case AmmoTypeId.ShotgunShell:
					return CreateShotgunShell(ammoTypeId, at);
				case AmmoTypeId.LongRange:
					return CreateLongRangeBullet(ammoTypeId, at);
				case AmmoTypeId.LaserBolt:
					return CreateLaserBolt(ammoTypeId, at);
				case AmmoTypeId.RocketMissile:
					return CreateRocketMissile(ammoTypeId, at);
			}

			throw new Exception($"Ammo for {ammoTypeId} type was not found");
		}


		private GameEntity CreateLightBullet(AmmoTypeId ammoTypeId, Vector3 at) =>
			CreateAmmoEntity(ammoTypeId, at)
				.With(x => x.isLightBullet = true);

		private GameEntity CreateRifleBullet(AmmoTypeId ammoTypeId, Vector3 at) =>
			CreateAmmoEntity(ammoTypeId, at)
				.With(x => x.isRifleBullet = true);

		private GameEntity CreateShotgunShell(AmmoTypeId ammoTypeId, Vector3 at) =>
			CreateAmmoEntity(ammoTypeId, at)
				.With(x => x.isShotgunShell = true);

		private GameEntity CreateLongRangeBullet(AmmoTypeId ammoTypeId, Vector3 at) =>
			CreateAmmoEntity(ammoTypeId, at)
				.With(x => x.isLongRangeBullet = true);

		private GameEntity CreateLaserBolt(AmmoTypeId ammoTypeId, Vector3 at) =>
			CreateAmmoEntity(ammoTypeId, at)
				.With(x => x.isLaserBolt = true);

		private GameEntity CreateRocketMissile(AmmoTypeId ammoTypeId, Vector3 at) =>
			CreateAmmoEntity(ammoTypeId, at)
				.With(x => x.isRocketMissile = true);

		private GameEntity CreateAmmoEntity(AmmoTypeId ammoTypeId, Vector3 at)
		{
			AmmoConfig config = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoStats stats = config.Stats;

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddAmmoTypeId(ammoTypeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddSpeed(stats.Speed)
					.AddRadius(stats.ContactRadius)
					.AddTargetsBuffer(new List<int>(TargetsBufferSize))
					.AddProcessedTargets(new List<int>(TargetsBufferSize))
					.AddLayerMask(CollisionLayer.Enemy.AsMask())
					.With(x => x.isAmmo = true)
					//.With(x => x.AddTargetLimit(_weaponStatsProvider.GetPierce()), when: stats.Pierce > 0)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isCollectTargetsContinuously = true)
				;
		}
	}
}