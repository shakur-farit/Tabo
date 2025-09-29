using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Door;
using Code.Gameplay.Features.Weapon;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Dungeon.Configs
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
		public DoorSetup DoorSetup;
	}

	[Serializable]
	public class DoorSetup
	{
		public DoorTypeId TypeId;
		public Vector2 DoorPosition;
	}
}