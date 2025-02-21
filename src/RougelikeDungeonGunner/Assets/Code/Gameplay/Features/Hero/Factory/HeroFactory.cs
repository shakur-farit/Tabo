using Code.Infrastructure.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Hero.Factory
{
	public class HeroFactory : IHeroFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IAssetProvider _assetProvider;

		public HeroFactory(IInstantiator instantiator, IAssetProvider assetProvider)
		{
			_instantiator = instantiator;
			_assetProvider = assetProvider;
		}

		public async void Create()
		{
			GameObject prefab = await _assetProvider.Load<GameObject>("TheGeneral");

			_instantiator.InstantiatePrefab(prefab);
		}
	}
}