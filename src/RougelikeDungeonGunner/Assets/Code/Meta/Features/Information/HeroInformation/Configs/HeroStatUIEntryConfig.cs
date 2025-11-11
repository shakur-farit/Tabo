using UnityEngine;

namespace Code.Meta.Features.Information.HeroInformation.Configs
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Information/Hero Stats UI Entry Config", fileName = "HeroStatUIEntryConfig")]
  public class HeroStatUIEntryConfig : ScriptableObject
  {
    public HeroStatUIEntryTypeId TypeId;
    public GameObject ViewPrefab;
  }
}