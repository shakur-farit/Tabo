using Code.Infrastructure.AssetManagement;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Hud.AmmoHolder.Factory
{
	public class AmmoUIFactory : IAmmoUIFactory
	{
		public const string AmmoUIAddress = "AmmoUI";

		private readonly IInstantiator _instantiator;
		private readonly IAssetProvider _assetProvider;

		public AmmoUIFactory(IInstantiator instantiator, IAssetProvider assetProvider)
		{
			_instantiator = instantiator;
			_assetProvider = assetProvider;
		}

		public async UniTask<GameObject> CreateAmmoUI(Transform parent)
		{
			GameObject prefab = await _assetProvider.Load<GameObject>(AmmoUIAddress);

			return _instantiator.InstantiatePrefab(prefab, parent);
		}
	}
}