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

		public GameEntity CreatePistolBullet(int level, Vector3 at)
		{
			AmmoConfig ammo = _staticDataService.GetAmmoConfig(AmmoId.PistolBullet);
			AmmoLevel ammoLevel = _staticDataService.GetAbilityLevel(AmmoId.PistolBullet, level);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddAmmoId(AmmoId.PistolBullet)
					.AddViewPrefab(ammo.ViewPrefab)
					.AddSpeed(ammoLevel.Speed)
					.AddTargetLimit(ammoLevel.Pierce)
					.AddRadius(ammoLevel.ContactRadius)
					.AddDamage(0)
					.AddTargetsBuffer(new List<int>(TargetsBufferSize))
					.AddProcessedTargets(new List<int>(TargetsBufferSize))
					.AddLayerMask(CollisionLayer.Enemy.AsMask())
					.With(x => x.isAmmo = true)
					.With(x => x.isPistolBullet = true)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isCollectTargetsContinuously = true)
				;
		}
	}
}