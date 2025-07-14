using System.Collections.Generic;
using Code.Common.Extensions;
using Entitas;

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
					GameMatcher.EnvironmentSetupAvailable));
		}

		public void Cleanup()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
				level
					.With(x => x.isEnvironmentSetupAvailable = false)
					;
		}
	}
}