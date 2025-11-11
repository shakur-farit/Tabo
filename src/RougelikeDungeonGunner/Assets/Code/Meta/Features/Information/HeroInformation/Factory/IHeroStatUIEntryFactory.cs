using UnityEngine;

namespace Code.Meta.Features.Information.HeroInformation.Factory
{
  public interface IHeroStatUIEntryFactory
  {
    void CreateHeroUIEntryItem(HeroStatUIEntryTypeId id, Transform parent, string value);
  }
}