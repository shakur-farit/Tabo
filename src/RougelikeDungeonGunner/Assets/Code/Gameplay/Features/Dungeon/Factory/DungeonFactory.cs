using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Levels
{
	public class DungeonFactory : IDungeonFactory
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IIdentifierService _identifier;
		private readonly IRandomService _random;

		public DungeonFactory(
			IStaticDataService staticDataService, 
			IIdentifierService identifier,
			IRandomService random)
		{
			_staticDataService = staticDataService;
			_identifier = identifier;
			_random = random;
		}

		public GameEntity CreateDungeon(DungeonTypeId typeId)
		{
			DungeonConfig config = _staticDataService.GetDungeonConfig(typeId);
			int randomIndex = _random.Range(0, config.EnvironmentSetups.Count);
			EnvironmentSetup environment = config.EnvironmentSetups[randomIndex];

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddViewPrefab(environment.ViewPrefab)
					.AddWorldPosition(Vector2.zero)
					.AddHeroStartPosition(environment.HeroStartPosition)
					.With(x => x.isDungeon = true)
				;
		}
	}
}