using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class CleanupClosestTargetSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _targets;
		private readonly List<GameEntity> _buffer = new(1);

		public CleanupClosestTargetSystem(GameContext game)
		{
			_targets = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.ClosestTarget));
		}

		public void Cleanup()
		{
			foreach (GameEntity target in _targets.GetEntities(_buffer)) 
				target.RemoveClosestTarget();
		}
	}
}