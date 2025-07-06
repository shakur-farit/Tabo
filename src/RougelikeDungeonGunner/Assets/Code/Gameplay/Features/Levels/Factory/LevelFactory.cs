using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Levels.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using Unity.VisualScripting.FullSerializer;

namespace Code.Gameplay.Features.Levels.Factory
{
	public class LevelFactory : ILevelFactory
	{
		private const int StartingEnemyWavesCount = 0;
		private const int StartingEnemiesCount = 0;

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

		public GameEntity CreateLevel(int level)
		{
			if (Enum.IsDefined(typeof(LevelTypeId), level))
			{
				LevelTypeId typeId = (LevelTypeId)level;
				LevelConfig config = _staticDataService.GetLevelConfig(typeId);

				int randomIndex = _random.Range(0, config.EnvironmentSetups.Count);

				return CreateEntity.Empty()
						.AddId(_identifier.Next())
						.AddEnemyWaves(config.EnemyWaves)
						.AddSpawnedEnemyWaves(StartingEnemyWavesCount)
						.AddEnvironmentSetup(config.EnvironmentSetups[randomIndex])
						.AddStartingTime(config.StartingTime)
						.AddStartingTimeLeft(config.StartingTime)
						.AddCooldown(config.TimeBetweenSpawnWaves)
						.AddCooldownLeft(config.TimeBetweenSpawnWaves)
						.AddEnemiesInLevelCount(StartingEnemiesCount)
						.AddFinishingTime(config.FinishingTime)
						.AddFinishingTimeLeft(config.FinishingTime)
						.With(x => x.isLevel = true)
						.With(x => x.isEnvironmentSetupAvailable = true)
						.With(x => x.isCooldownUp = true)
					;
			}

			throw new Exception($"Level with type id {level} does not exist");
		}
	}
}