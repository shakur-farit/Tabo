using System;
using System.Collections.Generic;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Levels
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Dungeon Config", fileName = "DungeonConfig")]
	public class DungeonConfig : ScriptableObject
	{
		public DungeonTypeId TypeId;
		public List<EnvironmentSetup> EnvironmentSetups;
	}

	[Serializable]
	public class EnvironmentSetup
	{
		public EntityBehaviour ViewPrefab;
		public Vector2 HeroStartPosition;
	}
}