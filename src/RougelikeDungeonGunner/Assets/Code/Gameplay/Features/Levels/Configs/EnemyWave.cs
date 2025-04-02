using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Enemy;

namespace Code.Gameplay.Features.Levels.Configs
{
	[Serializable]
	public class EnemyWave
	{
		public List<EnemiesInWave> EnemiesInWave;
	}

	[Serializable]
	public class EnemiesInWave
	{
		public EnemyTypeId EnemyTypeId;
		public int Amount;
	}
}