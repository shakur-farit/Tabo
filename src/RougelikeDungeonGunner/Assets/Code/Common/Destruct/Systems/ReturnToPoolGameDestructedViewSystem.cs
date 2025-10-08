using Code.Infrastructure.ObjectPool.Services;
using Code.Infrastructure.View;
using Entitas;

namespace Code.Common.Destruct.Systems
{
	public class ReturnToPoolGameDestructedViewSystem : ICleanupSystem
	{
		private readonly IObjectPoolService _objectPool;
		private readonly IGroup<GameEntity> _entities;

		public ReturnToPoolGameDestructedViewSystem(GameContext game, IObjectPoolService objectPool)
		{
			_objectPool = objectPool;
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Destructed,
					GameMatcher.View,
					GameMatcher.ViewPrefab,
					GameMatcher.Reusable));
		}

		public void Cleanup()
		{
			foreach (GameEntity entity in _entities)
			{
				IEntityView view = entity.View;

				entity.View.ReleaseEntity();
				
				_objectPool.Return(entity.ViewPrefab, view.EntityBehaviourObject);
			}
		}
	}
}