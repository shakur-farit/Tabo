using UnityEngine;
using Zenject;

namespace Code.Meta.Features.HeroSelector.Behaviours
{
  public class HeroSelectorDestroyer : MonoBehaviour
  {
    private IHeroSelectorProvider _heroSelectorProvider;

    [Inject]
    public void Constructor(IHeroSelectorProvider heroSelectorProvider) => 
      _heroSelectorProvider = heroSelectorProvider;

    public void Destroy() => 
      Destroy(_heroSelectorProvider.HeroSelector.gameObject);
  }
}