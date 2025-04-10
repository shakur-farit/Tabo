using System.Collections.Generic;
using Code.Common.Extensions;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Levels.Systems
{
	public class CleanupEnvironmentSetupSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _levels;
		private readonly List<GameEntity> _buffer = new(1);

		public CleanupEnvironmentSetupSystem(GameContext game)
		{
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnvironmentSetup,
					GameMatcher.EnvironmentSetupAvailable));
		}

		public void Cleanup()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
				level
					.RemoveEnvironmentSetup()
					.With(x => x.isEnvironmentSetupAvailable = false)
					;
		}
	}
}