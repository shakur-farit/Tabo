using Code.Gameplay.Features.Hero.Factory;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class SpawnHeroSystem : IExecuteSystem
	{
		private readonly IHeroFactory _heroFactory;
		private readonly IGroup<GameEntity> _levels;

		public SpawnHeroSystem(
			GameContext game,
			IHeroFactory heroFactory)
		{
			_heroFactory = heroFactory;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroStartPosition,
					GameMatcher.EnvironmentSetupAvailable));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
				_heroFactory.CreateHero(HeroTypeId.TheGeneral, level.HeroStartPosition);
		}
	}
}