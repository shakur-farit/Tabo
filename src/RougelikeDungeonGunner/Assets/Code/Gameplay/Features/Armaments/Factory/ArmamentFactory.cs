using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Abilities;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Armaments
{
	public class ArmamentFactory : IArmamentFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public ArmamentFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreatePistolBullet(int level, Vector3 at)
		{
			AbilityLevel abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.PistolBullet, level);
			ProjectileSetup setup = abilityLevel.ProjectileSetup;

			return CreateEntity.Empty()
				.AddId(_identifier.Next())
				.AddViewPrefab(abilityLevel.ViewPrefab)
				.With(x => x.isArmament = true)
				.AddWorldPosition(at)
				.AddSpeed(setup.Speed)
				.AddRadius(setup.ContactRadius)
				.AddTargetLimit(setup.Pierce)
				.AddDamage(1)
				.AddTargetsBuffer(new List<int>(16))
				.AddLayerMask(CollisionLayer.Enemy.AsMask())
				.With(x => x.isMovementAvailable = true)
				.With(x => x.isReadyToCollectTargets = true)
				.With(x => x.isCollectTargetsContinuously = true)
				;
		}
	}
}