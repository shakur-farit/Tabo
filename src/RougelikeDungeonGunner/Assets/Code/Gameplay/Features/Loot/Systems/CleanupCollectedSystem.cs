﻿using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CleanupCollectedSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _collected;

		public CleanupCollectedSystem(GameContext game)
		{
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected));
		}

		public void Cleanup()
		{
			foreach (GameEntity collected in _collected) 
				collected.isDestructed = true;
		}
	}
}