using System;
using System.Collections.Generic;
using System.Linq;
using Code.Common.Extensions;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class InitializeSpawnRequestSettingSystem : IInitializeSystem
	{
		private readonly ISpawnRequestSettingFactory _spawnRequestSettingFactory;

		public InitializeSpawnRequestSettingSystem(ISpawnRequestSettingFactory spawnRequestSettingFactory) =>
			_spawnRequestSettingFactory = spawnRequestSettingFactory;

		public void Initialize()
		{
			IEnumerable<SpawnRequestSettingTypeId> types = Enum.GetValues(typeof(SpawnRequestSettingTypeId))
				.Cast<SpawnRequestSettingTypeId>()
				.Where(x => x != SpawnRequestSettingTypeId.Unknown)
				.OrEmpty();

			foreach (SpawnRequestSettingTypeId type in types)
				_spawnRequestSettingFactory.CreateSpawnRequestSetting(type);
		}
	}
}