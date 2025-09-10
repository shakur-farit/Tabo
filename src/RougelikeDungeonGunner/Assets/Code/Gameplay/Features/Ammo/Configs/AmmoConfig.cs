using System;
using Code.Gameplay.Features.Collection;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Ammo Config", fileName = "AmmoConfig")]
	public class AmmoConfig : ScriptableObject
	{
		public AmmoTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		public Material Material;
		public AmmoStats Stats;
		public CollisionCastSetup CastSetup;
		public TrailSetup TrailSetup;
	}

	[Serializable]
	public class TrailSetup
	{
		public Material Material;
		[Range(0f, 10f)] public float Time;
		[Range(0f, 10f)] public float StartWidth;
		[Range(0f, 10f)] public float EndWidth;
	}
}