using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Sounds.SoundEffects.Config
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Sound Effect Config", fileName = "SoundEffectConfig")]
  public class SoundEffectConfig : ScriptableObject
  {
    public SoundEffectTypeId TypeId;
    public EntityBehaviour ViewPrefab;
    public AudioClip AudioClip;
    [Range(0f, 1f)] public float Volume;
    [Range(0f, 4f)] public float Lifetime;
  }
}