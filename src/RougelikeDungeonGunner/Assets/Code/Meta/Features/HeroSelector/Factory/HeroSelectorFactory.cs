using Code.Infrastructure.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Hud.HeroSelector.Behaviours
{
  public class HeroSelectorFactory : IHeroSelectorFactory
  {
    private const string HeroSelectorAddress = "HeroSelector";

    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public GameObject HeroSelector { get; private set; }

    public HeroSelectorFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }

    public async void CreateHeroSelector()
    {
      GameObject prefab = await _assetProvider.Load<GameObject>(HeroSelectorAddress);
      HeroSelector = _instantiator.InstantiatePrefab(prefab);
    }
  }
}