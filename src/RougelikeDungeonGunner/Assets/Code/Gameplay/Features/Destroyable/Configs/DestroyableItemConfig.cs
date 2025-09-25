using Code.Gameplay.Features.Loot;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Destroyable Item Config", fileName = "DestroyableItemConfig")]
  public class DestroyableItemConfig : ScriptableObject
  {
    public DestroyableItemTypeId TypeId;
    public DestroyableItemPlacingTypeId PlacingTypeId;
    public Sprite Sprite;
    public RuntimeAnimatorController AnimatorController;
    [Range(0, 100)] public int LootDropChance;
    public List<LootTypeId> ExcludedLoot;
  }
}