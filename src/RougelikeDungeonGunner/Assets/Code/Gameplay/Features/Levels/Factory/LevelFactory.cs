using Code.Infrastructure.Identifiers;
using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Levels.Configs;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Levels
{
	public class LevelFactory : ILevelFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;
		private readonly IRandomService _random;

		public LevelFactory(
			IIdentifierService identifier, 
			IStaticDataService staticDataService,
			IRandomService random)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
			_random = random;
		}

		public GameEntity CreateLevel(LevelTypeId typeId)
		{
			switch (typeId)
			{
				case LevelTypeId.First:
					return CreateFirstLevel(typeId);
			}

			throw new Exception($"Level with type id {typeId} does not exist");
		}

		private GameEntity CreateFirstLevel(LevelTypeId typeId) => 
			CreateLevelEntity(typeId);

		private GameEntity CreateLevelEntity(LevelTypeId typeId)
		{
			LevelConfig config = _staticDataService.GetLevelConfig(typeId);

			int randomIndex = _random.Range(0, config.EnvironmentSetups.Count);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddEnemyWaves(config.EnemyWaves)
					.AddCreatedEnemyWaves(0)
					.AddEnvironmentSetup(config.EnvironmentSetups[randomIndex])
					.AddCooldown(config.TimeBetweenSpawnWaves)
					.AddCooldownLeft(config.TimeBetweenSpawnWaves)
					.With(x => x.isEnvironmentSetupAvailable = true) 
					.With(x => x.isCooldownUp = true) 
				;
		}
	}
}