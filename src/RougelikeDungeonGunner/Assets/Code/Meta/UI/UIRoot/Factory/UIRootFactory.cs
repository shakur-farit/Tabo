using Code.Infrastructure.AssetManagement;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.UIRoot.Factory
{
	public class UIRootFactory : IUIRootFactory
	{
		private const string UIRootAddress = "VALUE";

		private readonly IAssetProvider _assetProvider;
		private readonly IInstantiator _instantiator;

		public GameObject UIRoot { get; private set; }

		public UIRootFactory(IAssetProvider assetProvider, IInstantiator instantiator)
		{
			_assetProvider = assetProvider;
			_instantiator = instantiator;
		}

		public async UniTask<GameObject> CreateUIRoot()
		{
			GameObject prefab = await _assetProvider.Load<GameObject>(UIRootAddress);
			UIRoot = _instantiator.InstantiatePrefab(prefab);

			Object.DontDestroyOnLoad(UIRoot);

			return UIRoot;
		}
	}
}