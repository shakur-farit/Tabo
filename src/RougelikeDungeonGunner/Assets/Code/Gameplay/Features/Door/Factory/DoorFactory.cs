using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Door.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Door.Factory
{
	public class DoorFactory : IDoorFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public DoorFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateDoor(DoorTypeId typeId, Vector3 at)
		{
			DoorConfig config = _staticDataService.GetDoorConfig(typeId);

			return CreateGameEntity.Empty()
					.AddId(_identifier.Next())
					.AddDoorTypeId(typeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddWorldPosition(at)
					.AddTargetsBuffer(new(1))
					.AddTargetLayerMask(CollisionLayer.Hero.AsMask())
					.AddRadius(1f)
					.With(x => x.isDoor = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isCollectTargetsContinuously = true)
				;
		}
	}
}