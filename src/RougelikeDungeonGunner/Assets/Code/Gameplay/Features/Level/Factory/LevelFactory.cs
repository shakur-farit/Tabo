using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Level.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.Level.Factory
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

				return CreateEntity.Empty()
						.AddId(_identifier.Next())
						.AddLevelTypeId(typeId)
						.AddDungeonTypeOnLevel(config.DungeonTypeOnLevel)
						.AddEnemyWaves(config.EnemyWaves)
						.AddSpawnedEnemyWaves(StartingEnemyWavesCount)
						.AddStartingTime(config.StartingTime)
						.AddStartingTimeLeft(config.StartingTime)
						.AddCooldown(config.TimeBetweenSpawnWaves)
						.AddCooldownLeft(config.TimeBetweenSpawnWaves)
						.AddEnemiesInLevelCount(StartingEnemiesCount)
						.AddFinishingTime(config.FinishingTime)
						.AddFinishingTimeLeft(config.FinishingTime)
						.AddHeroSafeZoneRadius(config.HeroSaveZoneRadius)
						.With(x => x.isLevel = true)
						.With(x => x.isCooldownUp = true)
					;
			}

			throw new Exception($"Level with type id {level} does not exist");
		}
	}
}