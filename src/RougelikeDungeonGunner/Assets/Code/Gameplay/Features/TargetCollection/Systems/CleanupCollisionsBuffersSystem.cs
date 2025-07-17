using Entitas;

namespace Code.Gameplay.Features.TargetCollection.Systems
{
	public class CleanupCollisionsBuffersSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public CleanupCollisionsBuffersSystem(GameContext game)
		{
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CollisionsBuffer));
		}

		public void Cleanup()
		{
			foreach (GameEntity entity in _entities)
				entity.CollisionsBuffer.Clear();
		}
	}
}