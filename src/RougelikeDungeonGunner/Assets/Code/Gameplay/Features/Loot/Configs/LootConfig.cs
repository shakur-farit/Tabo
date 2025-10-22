using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;
using Code.Infrastructure.View;
using Code.Sounds.SoundEffects;
using UnityEngine;

namespace Code.Gameplay.Features.Loot.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Loot Config", fileName = "LootConfig")]

	public class LootConfig : ScriptableObject
	{
		public LootTypeId TypeId;
		public SoundEffectTypeId PickupSoundEffectTypeId;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		[Range(0f, 100f)] public float DropChanceWeight;
    [Range(0, 1000)] public int Value;

		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;
	}
}