using Code.Gameplay.Features.Level;
using Entitas;
using System.Collections.Generic;

namespace Code.Gameplay.Features.Door.Systems
{
	public class OpenDoorOnAllEnemiesDeadSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _doors;

		public OpenDoorOnAllEnemiesDeadSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.BossesDefeated));

			_doors = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Door));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels)
			foreach (GameEntity door in _doors.GetEntities(_buffer))
          door.isOpened = true;
    }
	}
}