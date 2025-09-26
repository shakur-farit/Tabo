using Entitas;

namespace Code.Gameplay.Features.Collection.Systems
{
	public class CleanupDestroyableTargetBuffersSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public CleanupDestroyableTargetBuffersSystem(GameContext game)
		{
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.DestroyableTargetsBuffer));
		}

		public void Cleanup()
		{
			foreach (GameEntity entity in _entities)
				entity.DestroyableTargetsBuffer.Clear();
		}
	}
}