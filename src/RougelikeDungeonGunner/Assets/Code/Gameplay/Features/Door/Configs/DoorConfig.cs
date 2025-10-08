using Code.Gameplay.Features.Music;
using Code.Infrastructure.View;
using Code.Sounds.SoundEffects;
using UnityEngine;

namespace Code.Gameplay.Features.Door.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Door Config", fileName = "DoorConfig")]
	public class DoorConfig : ScriptableObject
	{
		public DoorTypeId TypeId;
		public SoundEffectTypeId OpeningSoundEffectTypeId;
		public EntityBehaviour ViewPrefab;
		[Range(0.1f, 5f)] public float ContacnRadius;
	}
}