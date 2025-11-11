using Code.Gameplay.StaticData;
using Code.Meta.Features.Information.HeroInformation.Behaviours;
using Code.Meta.Features.Information.HeroInformation.Configs;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Information.HeroInformation.Factory
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

      item.Initialize(id, value);
    }
  }
}