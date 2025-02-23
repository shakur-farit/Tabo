using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Identifiers;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Hero.Factory
{
	public class HeroFactory : IHeroFactory
	{
		private const string HeroViewPath = "TheGeneral";

		private readonly IIdentifierService _identifier;
		private readonly IAssetProvider _assetProvider;
		private readonly IInstantiator _instantiator;

		public HeroFactory(IIdentifierService identifier, IAssetProvider assetProvider, IInstantiator instantiator)
		{
			_identifier = identifier;
			_assetProvider = assetProvider;
			_instantiator = instantiator;
		}

		public GameEntity Create(Vector3 at)
		{
			  return CreateEntity.Empty()
				.AddId(_identifier.Next())
				.AddWorldPosition(at)
				.AddDirection(Vector2.zero)
				.AddSpeed(2)
				.AddViewPath(HeroViewPath)
				.With(x => x.isHero = true)
				;
		}

		public async void CreatePrefab()
		{
			var prefab = await _assetProvider.Load<GameObject>(HeroViewPath);

			_instantiator.InstantiatePrefab(prefab);
		}
	}
}