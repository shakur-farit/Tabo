using System.Collections.Generic;
using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Music;
using Code.Infrastructure.View;
using Code.Sounds.SoundEffects;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Configs
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Destroyable Item Config", fileName = "DestroyableItemConfig")]
  public class DestroyableItemConfig : ScriptableObject
  {
    public DestroyableItemTypeId TypeId;
    public DestroyableItemPlacingTypeId PlacingTypeId;
    public SoundEffectTypeId DestroyingSoundEffectTypeId;
    public EntityBehaviour ViewPrefab; 
    public Sprite Sprite;
    public RuntimeAnimatorController AnimatorController;
    [Range(0, 100)] public int LootDropChance;
    public List<LootTypeId> ExcludedLoot;
  }
}