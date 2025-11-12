using Code.Gameplay.StaticData;
using Zenject;

namespace Code.Meta.Features.HeroSelector.Behaviours
{
  public class HeroSelectorFactory : IHeroSelectorFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IStaticDataService _staticDataService;

    public HeroSelectorFactory(IInstantiator instantiator, IStaticDataService staticDataService)
    {
      _instantiator = instantiator;
      _staticDataService = staticDataService;
    }

    public HeroSelectorBehaviour CreateHeroSelector()
    {
      HeroSelectorConfig config = _staticDataService.GetHeroSelectorConfig();

      return _instantiator.InstantiatePrefabForComponent<HeroSelectorBehaviour>(config.ViewPrefab);
    }
  }
}