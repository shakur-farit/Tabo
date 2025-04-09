using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Levels
{
	public class MarkProcessedOnAllEnemiesDeadSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;

		public MarkProcessedOnAllEnemiesDeadSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemiesInLevelCount));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			{
				if (level.EnemiesInLevelCount <= 0)
				{
					level.isProcessed = true;
				}
			}
		}
	}
}