using UnityEngine;

namespace Code.Meta.Features.Hud.Config
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Hud Config", fileName = "HudConfig")]
  public class HudConfig : ScriptableObject
  {
    public int MaxHeartSpritesCount;
    public GameObject HeathViewPrefab;
  }
}