using Code.Progress.Provider;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectCoinsSystem : IExecuteSystem
	{
		private readonly IProgressProvider _progressProvider;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _heroes;

		public CollectCoinsSystem(GameContext game, IProgressProvider progressProvider)
		{
			_progressProvider = progressProvider;
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.Coins));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Coins));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity collected in _collected)
			{
				hero.ReplaceCoins(hero.Coins + collected.Coins);
				_progressProvider.HeroData.CurrentCoinsCount = hero.Coins;
			}
		}
	}
}