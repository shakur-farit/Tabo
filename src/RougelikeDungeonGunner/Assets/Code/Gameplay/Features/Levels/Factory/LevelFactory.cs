using Code.Infrastructure.Identifiers;
using System;
using Code.Common.Entity;
using Code.Gameplay.Features.Levels.Configs;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Levels
{
	public class LevelFactory : ILevelFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public LevelFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
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

		private GameEntity CreateFirstLevel(LevelTypeId typeId)
		{
			return CreateLevelEntity(typeId);
		}

		private GameEntity CreateLevelEntity(LevelTypeId typeId)
		{
			LevelConfig config = _staticDataService.GetLevelConfig(typeId);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddEnemyWaves(config.EnemyWaves)
				;
		}
	}
}