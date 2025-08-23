using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
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
		public float Radius;
		public float Duration;
		public float Period;
		public List<EffectSetup> EffectSetups;
	}
}