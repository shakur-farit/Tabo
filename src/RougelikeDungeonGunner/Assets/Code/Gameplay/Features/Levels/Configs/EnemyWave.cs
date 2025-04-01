using System;
using Code.Gameplay.Features.Enemy;

namespace Code.Gameplay.Features.Levels.Configs
{
	[Serializable]
	public class EnemyWave
	{
		public EnemyTypeId EnemyTypeId;
		public int Amount;
	}
}