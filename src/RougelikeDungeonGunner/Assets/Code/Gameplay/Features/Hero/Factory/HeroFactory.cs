using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Hero.Behaviours;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Identifiers;
using Code.Infrastructure.View;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Hero.Factory
{
	public class HeroFactory : IHeroFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IAssetProvider _assetProvider;
		private readonly IIdentifierService _identifier;

		public HeroFactory(
			IInstantiator instantiator, 
			IAssetProvider assetProvider,
			IIdentifierService identifier)
		{
			_instantiator = instantiator;
			_assetProvider = assetProvider;
			_identifier = identifier;
		}

		public async void Create()
		{
			GameObject prefab = await _assetProvider.Load<GameObject>("TheGeneral");

			_instantiator.InstantiatePrefab(prefab);

			EntityBehaviour entityBehaviour = prefab.GetComponent<EntityBehaviour>();
			HeroAnimator animator = prefab.GetComponent<HeroAnimator>();

			GameEntity entity = CreateEntity.Empty();

			entity
				.AddId(_identifier.Next())
				.AddView(entityBehaviour)
				.AddTransform(prefab.transform)
				.AddWorldPosition(prefab.transform.position)
				.AddSpeed(2)
				.AddDirection(Vector2.zero)
				.AddHeroAnimator(animator)
				.With(x => x.isHero = true);

			entityBehaviour.SetEntity(entity);
		}
	}
}