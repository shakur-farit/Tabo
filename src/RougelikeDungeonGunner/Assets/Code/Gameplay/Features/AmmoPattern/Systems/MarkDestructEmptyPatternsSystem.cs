using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.AmmoPattern.Systems
{
	public class MarkDestructEmptyPatternsSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _patterns;
		private readonly List<GameEntity> _buffer = new(64);

		public MarkDestructEmptyPatternsSystem(GameContext game)
		{
			_patterns = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoTransformsList));
		}

		public void Execute()
		{
			foreach (GameEntity pattern in _patterns.GetEntities(_buffer))
			{
				if (pattern.AmmoTransformsList.Count <= 0)
					pattern.isDestructed = true;
			}
		}
	}
}