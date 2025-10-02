using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Music
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Sound Effect Config", fileName = "SoundEffectConfig")]
  public class SoundEffectConfig : ScriptableObject
  {
    public SoundEffectsTypeId TypeId;
    public EntityBehaviour ViewPrefab;
    public AudioClip AudioClip;
    public float Volume;
  }
}