using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.Features.Collection;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Factory
{
	public class AmmoFactory : IAmmoFactory
	{
		private const int BufferSize = 16;
		private const int NoLimit = 0;

		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public AmmoFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
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
				case AmmoTypeId.EnemyBullet:
					return CreateEnemyBullet(ammoTypeId, at);
				case AmmoTypeId.SigilAmmo:
					return CreateSigilAmmo(ammoTypeId, at);

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

		private GameEntity CreateEnemyBullet(AmmoTypeId ammoTypeId, Vector3 at) =>
			CreateAmmoEntity(ammoTypeId, at)
				.With(x => x.isEnemyBullet = true);

		private GameEntity CreateSigilAmmo(AmmoTypeId ammoTypeId, Vector3 at) =>
			CreateAmmoEntity(ammoTypeId, at)
				.With(x => x.isSigilAmmo = true);

		private GameEntity CreateAmmoEntity(AmmoTypeId ammoTypeId, Vector3 at)
		{
			AmmoConfig config = _staticDataService.GetAmmoConfig(ammoTypeId);
			AmmoStats stats = config.Stats;
			CollisionCastSetup castSetup = config.CastSetup;

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddAmmoTypeId(ammoTypeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddRadius(stats.ContactRadius)
					.AddForwardCastDistance(castSetup.ForwardCastDistance)
					.AddTargetsBuffer(new List<int>(BufferSize))
					.AddTargetLimit(NoLimit)
					.AddProcessedTargets(new List<int>(BufferSize))
					.With(x => x.isAmmo = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isCollectTargetsContinuously = true)
				;
		}
	}
}