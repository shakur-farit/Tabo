using UnityEngine;

namespace Code.Meta.Features.HeroSelector.Behaviours
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Hero Selector Config", fileName = "HeroSelectorConfig")]

  public class HeroSelectorConfig : ScriptableObject
  {
    public GameObject ViewPrefab;
  }
}