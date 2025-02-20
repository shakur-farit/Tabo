using Code.Infrastructure.AssetManagement;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Gameplay.StaticData
{
  public class StaticDataService : IStaticDataService
  {

	  private readonly IAssetProvider _assetProvider;

	  public StaticDataService(IAssetProvider assetProvider) => 
      _assetProvider = assetProvider;

	  public async UniTask Load()
	  {

	  }

	  public async UniTask Preload()
	  {

	  }
  }
}