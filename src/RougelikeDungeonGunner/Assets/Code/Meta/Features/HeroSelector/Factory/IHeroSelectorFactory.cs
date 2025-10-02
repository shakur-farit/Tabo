using UnityEngine;

namespace Code.Meta.Features.Hud.HeroSelector.Behaviours
{
  public interface IHeroSelectorFactory
  {
    void CreateHeroSelector();
    GameObject HeroSelector { get; }
  }
}