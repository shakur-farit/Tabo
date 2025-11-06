using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.Features.Collection;
using Code.Gameplay.Features.SpecialEffect;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Factory
{
	public class AmmoFactory : IAmmoFactory
	{
		private const int BufferSize = 16;

		private readonly Dictionary<AmmoTypeId, Func<AmmoTypeId, Vector3, GameEntity>> _factories;

		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public AmmoFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;

			_factories = new Dictionary<AmmoTypeId, Func<AmmoTypeId, Vector3, GameEntity>>
			{
				{ AmmoTypeId.Light, CreateLightBullet },
				{ AmmoTypeId.Rifle, CreateRifleBullet },
				{ AmmoTypeId.ShotgunShell, CreateShotgunShell },
				{ AmmoTypeId.LongRange, CreateLongRangeBullet },
				{ AmmoTypeId.LaserBolt, CreateLaserBolt },
				{ AmmoTypeId.RocketMissile, CreateRocketMissile },
				{ AmmoTypeId.EnemyBullet, CreateEnemyBullet },
				{ AmmoTypeId.SigilAmmo, CreateSigilAmmo }
			};
		}

		public GameEntity CreateAmmo(AmmoTypeId ammoTypeId, Vector3 at)
		{
			if (_factories.TryGetValue(ammoTypeId, out Func<AmmoTypeId, Vector3, GameEntity> creator))
				return creator.Invoke(ammoTypeId, at);

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
			CollisionCastSetup castSetup = config.CastSetup;

			return CreateGameEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddAmmoTypeId(ammoTypeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddRadius(config.ContactRadius)
					.AddForwardCastDistance(castSetup.ForwardCastDistance)
					.AddTargetsBuffer(new List<int>(BufferSize))
          .AddProcessedTargets(new List<int>(BufferSize))
					.AddDestroyableCollectRadius(config.ContactRadius)
					//.AddDestroyableTargetLayerMask(CollisionLayer.Destroyable.AsMask())
					.AddDestroyableTargetsBuffer(new(BufferSize))
					.With(x => x.AddSpecialEffectTypeId(config.CollideSpecialEffectTypeId),
						when: config.CollideSpecialEffectTypeId != SpecialEffectTypeId.NoSpecialEffect)
					.With(x => x.isAmmo = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isCollectTargetsContinuously = true)
					.With(x => x.isReusable = true)
				;
		}
	}
}