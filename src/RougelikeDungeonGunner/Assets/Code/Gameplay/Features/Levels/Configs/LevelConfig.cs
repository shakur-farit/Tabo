using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Levels.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Level Config", fileName = "LevelConfig")]
	public class LevelConfig : ScriptableObject
	{
		public LevelTypeId LevelTypeId;
		public int StartingTime;
		public int TimeBetweenSpawnWaves;
		public int FinishingTime;
		public List<EnvironmentSetup> EnvironmentSetups;
		public List<EnemiesSpawnSetup> SpawnSetups;
	}
}