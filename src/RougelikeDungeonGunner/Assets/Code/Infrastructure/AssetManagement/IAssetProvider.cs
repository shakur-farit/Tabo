using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
  public interface IAssetProvider
  {
	  UniTask Initialize();
	  UniTask<T> Load<T>(string addressReference) where T : class;
	  void Preload<T>(string addressReference) where T : class;
	  void Release(string addressReference);
	  void CleanUp();
  }
}