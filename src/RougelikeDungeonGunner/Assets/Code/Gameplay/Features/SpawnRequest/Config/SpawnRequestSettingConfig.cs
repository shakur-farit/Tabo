using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{

  [CreateAssetMenu(menuName = "Dungeon Gunner/Spawn Request Setting Config", fileName = "SpawnRequestSettingConfig")]
  public class SpawnRequestSettingConfig : ScriptableObject
  {
	  public SpawnRequestSettingTypeId TypeId;
    [Range(1, 100)] public int MaxSpawnPerFrame;
  }
}