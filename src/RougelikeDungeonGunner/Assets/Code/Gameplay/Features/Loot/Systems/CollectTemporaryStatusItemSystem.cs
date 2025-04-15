using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectTemporaryStatusItemSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public CollectTemporaryStatusItemSystem(GameContext game)
		{
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.TemporaryStatusSetups));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			foreach (GameEntity collected in _collected)
			{
				List<TemporaryStatusData> statusSetups = collected.TemporaryStatusSetups;

				if (weapon.hasTemporaryStatusSetups == false)
				{
					weapon.AddTemporaryStatusSetups(statusSetups);
				}
				else
				{
					foreach (TemporaryStatusData status in statusSetups)
					{
						TemporaryStatusData existingStatus = weapon.TemporaryStatusSetups
							.Find(s => s.Setup.StatusTypeId == status.Setup.StatusTypeId);

						if (existingStatus.Setup != null)
							existingStatus.Duration = status.Duration;
						else
							weapon.TemporaryStatusSetups.Add(status);
					}
				}
			}
		}
	}
}