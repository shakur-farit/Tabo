using Entitas;

namespace Code.Gameplay.Features.Levels
{
	public class MarkHeroDestructedOnLevelProcessedSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _heroes;

		public MarkHeroDestructedOnLevelProcessedSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Processed,
					GameMatcher.Level));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			foreach (GameEntity hero in _heroes)
			{
				hero.isDestructed = true;
			}
		}
	}
}