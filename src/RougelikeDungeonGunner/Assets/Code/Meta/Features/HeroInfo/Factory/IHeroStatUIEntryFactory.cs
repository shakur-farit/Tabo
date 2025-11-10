using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry
{
  public interface IHeroStatUIEntryFactory
  {
    void CreateHeroUIEntryItem(HeroStatUIEntryTypeId id, Transform parent, string value);
  }
}