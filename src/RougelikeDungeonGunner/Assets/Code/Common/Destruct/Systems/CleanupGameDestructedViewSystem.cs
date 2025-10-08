using Code.Infrastructure.ObjectPool.Services;
using Entitas;
using UnityEngine;

namespace Code.Common.Destruct.Systems
{
	public class CleanupGameDestructedViewSystem : ICleanupSystem
	{
		private readonly IObjectPoolService _objectPool;
		private readonly IGroup<GameEntity> _entities;

		public CleanupGameDestructedViewSystem(GameContext game, IObjectPoolService objectPool)
		{
			_objectPool = objectPool;
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Destructed,
					GameMatcher.View)
				.NoneOf(GameMatcher.Reusable));
		}

		public void Cleanup()
		{
			foreach (GameEntity entity in _entities)
			{
				entity.View.ReleaseEntity();

				Object.Destroy(entity.View.gameObject);
			}
		}
	}
}

  