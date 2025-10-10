using UnityEngine;

namespace Code.Meta.Features.HeroSelector.Factory
{
  public interface IHeroSelectorFactory
  {
    void CreateHeroSelector();
    GameObject HeroSelector { get; }
  }
}