using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Door.Systems
{
	public class MarkLevelProcessedOnHeroDetectedSystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _doors;
		private readonly IGroup<GameEntity> _levels;

		public MarkLevelProcessedOnHeroDetectedSystem(GameContext game)
		{
			_game = game;
			_doors = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Door,
					GameMatcher.TargetsBuffer,
					GameMatcher.Reached,
					GameMatcher.Opened));

			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level));
		}

		public void Execute()
		{
			foreach (GameEntity door in _doors)
			foreach (int id in door.TargetsBuffer)
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				GameEntity target = _game.GetEntityWithId(id);

				if(target.isHero == false)
					continue;

				level.isProcessed = door.isOpened;
			}
		}
	}
}