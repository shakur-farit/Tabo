namespace Code.Gameplay.Features.Collection
{
	public static class CollectionEntityExtensions
	{
		public static GameEntity RemoveTargetCollectionComponents(this GameEntity entity)
		{
			if (entity.hasTargetsBuffer)
				entity.RemoveTargetsBuffer();

			if (entity.hasCollectTargetsInterval)
				entity.RemoveCollectTargetsInterval();

			if (entity.hasCollectTargetsTimer)
				entity.RemoveCollectTargetsTimer();

			entity.isReadyToCollectTargets = false;

			return entity;
		}
	}
}