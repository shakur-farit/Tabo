using System.Collections.Generic;
using Code.Gameplay.Features.Dungeon.Factory;
using Entitas;

namespace Code.Gameplay.Features.Dungeon.Systems
{
	public class CreateDungeonSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IDungeonFactory _dungeonFactory;
		private readonly IGroup<GameEntity> _levels;

		public CreateDungeonSystem(GameContext game, IDungeonFactory dungeonFactory)
		{
			_dungeonFactory = dungeonFactory;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level)
				.NoneOf(GameMatcher.DungeonAvailable));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				_dungeonFactory.CreateDungeon(level.DungeonTypeOnLevel);

				level.isDungeonAvailable = true;
			}
		}
	}
}