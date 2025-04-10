using System.Collections.Generic;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Levels.Configs;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Levels.Services
{
	public class LevelEnvironmentService : ILevelEnvironmentService
	{
		private readonly StaticDataService _staticDataService;
		private readonly IRandomService _random;

		public LevelEnvironmentService(StaticDataService staticDataService, IRandomService random)
		{
			_staticDataService = staticDataService;
			_random = random;
		}

		public EnvironmentSetup GetEnvironmentSetup(LevelTypeId levelId)
		{
			List<EnvironmentSetup> environmentSetups = _staticDataService.GetLevelConfig(levelId).EnvironmentSetups;
			int randomIndex = _random.Range(0, environmentSetups.Count - 1);
			return environmentSetups[randomIndex];
		}
	}
}