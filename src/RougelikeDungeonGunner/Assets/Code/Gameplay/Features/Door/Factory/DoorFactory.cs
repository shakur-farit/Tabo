using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
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

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddDoorTypeId(typeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddWorldPosition(at)
					.With(x => x.isDoor = true)
				;
		}
	}
}