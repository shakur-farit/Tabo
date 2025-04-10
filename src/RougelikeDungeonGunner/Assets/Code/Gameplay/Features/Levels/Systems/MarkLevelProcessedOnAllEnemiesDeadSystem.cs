using Entitas;

namespace Code.Gameplay.Features.Levels.Systems
{
	public class MarkLevelProcessedOnAllEnemiesDeadSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;

		public MarkLevelProcessedOnAllEnemiesDeadSystem(GameContext game)
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