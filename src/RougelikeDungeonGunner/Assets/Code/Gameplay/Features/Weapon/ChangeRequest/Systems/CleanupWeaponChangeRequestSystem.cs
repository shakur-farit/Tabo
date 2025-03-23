using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.ChangeRequest.Systems
{
	public class CleanupWeaponChangeRequestSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _changeRequests;
		private readonly List<GameEntity> _buffer = new(1);

		public CleanupWeaponChangeRequestSystem(GameContext game)
		{
			_changeRequests = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponChangeRequested,
					GameMatcher.Processed));
		}

		public void Cleanup()
		{
			foreach (GameEntity changeRequests in _changeRequests.GetEntities(_buffer))
				changeRequests.isDestructed = true;
		}
	}
}