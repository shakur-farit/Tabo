using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Levels.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Level Config", fileName = "LevelConfig")]
	public class LevelConfig : ScriptableObject
	{
		public LevelTypeId TypeId;
		public DungeonTypeId DungeonTypeOnLevel;
		[Range(0, 100)] public int StartingTime;
		[Range(0, 100)] public int TimeBetweenSpawnWaves;
		[Range(0, 100)] public int FinishingTime;
		[Range(0, 100)] public float HeroSaveZoneRadius;
		public List<EnemyWave> EnemyWaves;
	}
}