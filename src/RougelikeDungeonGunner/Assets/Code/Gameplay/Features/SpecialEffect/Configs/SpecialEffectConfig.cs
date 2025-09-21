using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Special Effect Config", fileName = "SpecialEffectConfig")]
	public class SpecialEffectConfig : ScriptableObject
	{
		public SpecialEffectTypeId TypeId;
		public EntityBehaviour ViewPrefab;
    [Range(0.1f, 3f)] public float Lifetime;
  }
}