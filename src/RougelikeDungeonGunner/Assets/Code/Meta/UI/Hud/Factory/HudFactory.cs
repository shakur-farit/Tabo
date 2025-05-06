using Code.Infrastructure.AssetManagement;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.UIRoot.Factory
{
	public class HudFactory : IHudFactory
	{
		private const string HudAddress = "VALUE";

		private readonly IAssetProvider _assetProvider;
		private readonly IInstantiator _instantiator;

		public GameObject Hud { get; private set; }

		public HudFactory(IAssetProvider assetProvider, IInstantiator instantiator)
		{
			_assetProvider = assetProvider;
			_instantiator = instantiator;
		}

		public async UniTask<GameObject> CreateHud(Transform parent)
		{
			GameObject prefab = await _assetProvider.Load<GameObject>(HudAddress);
			Hud = _instantiator.InstantiatePrefab(prefab, parent);

			return Hud;
		}
	}
}