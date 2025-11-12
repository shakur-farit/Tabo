namespace Code.Meta.Features.HeroSelector.Behaviours
{
  public interface IHeroSelectorProvider
  {
    HeroSelectorBehaviour HeroSelector { get; }
    void CreateHeroSelector();
  }
}