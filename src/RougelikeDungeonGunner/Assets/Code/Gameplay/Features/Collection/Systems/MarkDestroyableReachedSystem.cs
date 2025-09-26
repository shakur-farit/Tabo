using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Collection.Systems
{
	public class MarkDestroyableReachedSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(64);

		private readonly IGroup<GameEntity> _entities;

		public MarkDestroyableReachedSystem(GameContext game)
		{
			_entities = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.DestroyableTargetsBuffer)
				.NoneOf(GameMatcher.Reached));
		}

		public void Execute()
		{
			foreach (GameEntity entity in _entities.GetEntities(_buffer))
			{
				if (entity.DestroyableTargetsBuffer.Count > 0)
					entity.isReached = true;
			}
		}
	}
}