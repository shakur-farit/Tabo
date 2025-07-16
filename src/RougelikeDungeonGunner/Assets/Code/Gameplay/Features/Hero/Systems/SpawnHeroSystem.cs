using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Factory;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class SpawnHeroSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IHeroFactory _heroFactory;
		private readonly IGroup<GameEntity> _dungeons;

		public SpawnHeroSystem(
			GameContext game,
			IHeroFactory heroFactory)
		{
			_heroFactory = heroFactory;
			_dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Dungeon,
					GameMatcher.HeroStartPosition)
				.NoneOf(GameMatcher.HeroAvailable));
		}

		public void Execute()
		{
			foreach (GameEntity dungeon in _dungeons.GetEntities(_buffer))
			{
				_heroFactory.CreateHero(HeroTypeId.TheGeneral, dungeon.HeroStartPosition);

				dungeon.isHeroAvailable = true;
			}
		}
	}
}