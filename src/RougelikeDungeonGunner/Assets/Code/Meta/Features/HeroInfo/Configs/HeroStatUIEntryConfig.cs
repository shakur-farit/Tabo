using Code.Meta.Features.Shop.EnchantUIEntry;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry.Factory;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Information/Hero Stats UI Entry Config", fileName = "HeroStatUIEntryConfig")]
  public class HeroStatUIEntryConfig : ScriptableObject
  {
    public HeroStatUIEntryTypeId TypeId;
    public GameObject ViewPrefab;
  }
}