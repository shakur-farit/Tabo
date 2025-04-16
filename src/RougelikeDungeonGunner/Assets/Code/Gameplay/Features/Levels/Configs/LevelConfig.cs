using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Levels.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Level Config", fileName = "LevelConfig")]
	public class LevelConfig : ScriptableObject
	{
		public LevelTypeId TypeId;
		public int StartingTime;
		public int TimeBetweenSpawnWaves;
		public int FinishingTime;
		public List<EnvironmentSetup> EnvironmentSetups;
		public List<EnemyWave> EnemyWaves;
	}
}