using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectCoinsSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _heroes;

		public CollectCoinsSystem(GameContext game)
		{
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.Coin));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Coin));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity collected in _collected)
				hero.ReplaceCoin(hero.Coin + collected.Coin);
		}
	}
}