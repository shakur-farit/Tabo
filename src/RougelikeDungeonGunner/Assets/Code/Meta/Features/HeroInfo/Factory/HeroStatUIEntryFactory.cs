using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry
{
  public class HeroStatUIEntryFactory : IHeroStatUIEntryFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IStaticDataService _staticDataService;

    public HeroStatUIEntryFactory(IInstantiator instantiator, IStaticDataService staticDataService)
    {
      _instantiator = instantiator;
      _staticDataService = staticDataService;
    }

    public void CreateHeroUIEntryItem(HeroStatUIEntryTypeId id, Transform parent, string value)
    {
      HeroStatUIEntryConfig config = _staticDataService.GetHeroStatUIEntryItemConfig(id);
      HeroStatUIEntryItem item = _instantiator
        .InstantiatePrefabForComponent<HeroStatUIEntryItem>(config.ViewPrefab, parent);

      item.Setup(id, value);
    }
  }
}