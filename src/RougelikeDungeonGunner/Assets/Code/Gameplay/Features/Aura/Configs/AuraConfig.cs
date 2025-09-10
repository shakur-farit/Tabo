using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Aura Config", fileName = "AuraConfig")]
	public class AuraConfig : ScriptableObject
	{
		public AuraTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		public Material Material;
		[Range(0f, 1f)] public float Alpha;
		[Range(0f, 10f)] public float Radius;
		[Range(0f, 100f)] public float Duration;
		[Range(0f, 100f)] public float Interval;
		[Range(0f, 100f)] public int Durability;
		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;
	}
}