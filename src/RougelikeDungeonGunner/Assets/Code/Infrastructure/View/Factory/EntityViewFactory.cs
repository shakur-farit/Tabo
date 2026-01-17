using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.ObjectPool.Services;
using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Infrastructure.View.Factory
{
	public class EntityViewFactory : IEntityViewFactory
	{
		private readonly Dictionary<GameEntity, bool> _loadingInProgress = new();
		private readonly Vector3 _farAway = new(-999, 999, 0);

		private readonly IAssetProvider _assetProvider;
    private readonly IObjectPoolService _objectPool;

    public EntityViewFactory(IAssetProvider assetProvider, IObjectPoolService objectPool)
		{
			_assetProvider = assetProvider;
      _objectPool = objectPool;
    }

		public async UniTask<EntityBehaviour> CreateViewForEntity(GameEntity entity)
		{
			if (_loadingInProgress.ContainsKey(entity) && _loadingInProgress[entity])
				return null;

			try
			{
				_loadingInProgress[entity] = true;

				EntityBehaviour viewPrefab = await _assetProvider.LoadComponent<EntityBehaviour>(entity.ViewPath);
			  EntityBehaviour view = _objectPool.Get(viewPrefab, _farAway);

				view.SetEntity(entity);

        return view;
			}
			finally
			{
				_loadingInProgress[entity] = false;
			}
		}

		public EntityBehaviour CreateViewForEntityFromPrefab(GameEntity entity)
    {
			EntityBehaviour view = _objectPool.Get(entity.ViewPrefab, _farAway);

      view.SetEntity(entity);

      return view;
		}
	}
}