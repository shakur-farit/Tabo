using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Enemy;

namespace Code.Gameplay.Features.Levels.Configs
{
	[Serializable]
	public class EnemiesSpawnSetup
	{
		public List<EnemiesWave> EnemiesWaves;
	}

	[Serializable]
	public class EnemiesWave
	{
		public EnemyTypeId EnemyTypeId;
		public int Amount;
	}
}