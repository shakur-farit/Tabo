namespace Code.Meta.Features.HeroSelector.Behaviours
{
  public class HeroSelectorProvider : IHeroSelectorProvider
  {
    private readonly IHeroSelectorFactory _factory;

    public HeroSelectorBehaviour HeroSelector { get; private set; }

    public HeroSelectorProvider(IHeroSelectorFactory factory) => 
      _factory = factory;

    public void CreateHeroSelector() => 
      HeroSelector = _factory.CreateHeroSelector();
  }
}