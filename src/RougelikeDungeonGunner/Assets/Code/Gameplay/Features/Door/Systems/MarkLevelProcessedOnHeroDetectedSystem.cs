using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	public class MarkLevelProcessedOnHeroDetectedSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _doors;
		private readonly IGroup<GameEntity> _levels;

		public MarkLevelProcessedOnHeroDetectedSystem(GameContext game)
		{
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
			foreach (GameEntity level in _levels.GetEntities(_buffer))
				level.isProcessed = door.isOpened;
		}
	}
}