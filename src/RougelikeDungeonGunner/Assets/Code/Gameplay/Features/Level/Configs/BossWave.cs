using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Enemy;
using UnityEngine;

namespace Code.Gameplay.Features.Level.Configs
{
	[Serializable]
	public class BossWave
	{
		public List<BossesInWave> Bosses;
	}

	[Serializable]
	public class BossesInWave
	{
		public EnemyTypeId EnemyTypeId;
		[Range(0, 100)] public int Amount;
	}
}