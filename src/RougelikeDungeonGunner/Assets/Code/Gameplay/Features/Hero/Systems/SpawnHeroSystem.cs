using System.Collections.Generic;
using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Hero.Services;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class SpawnHeroSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly ICurrentHeroTypeIdProvider _heroType;
		private readonly IHeroFactory _heroFactory;
		private readonly IGroup<GameEntity> _dungeons;

		public SpawnHeroSystem(
			GameContext game,
			ICurrentHeroTypeIdProvider heroType,
			IHeroFactory heroFactory)
		{
			_heroType = heroType;
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
				_heroFactory.CreateHero(_heroType.CurrentHeroTypeId, dungeon.HeroStartPosition);

				dungeon.isHeroAvailable = true;
			}
		}
	}
}