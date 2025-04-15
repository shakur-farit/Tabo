using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class ApplyCombinedStatusesToAmmoSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(32);

		public ApplyCombinedStatusesToAmmoSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo)
				.NoneOf(GameMatcher.StatusSetups));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.TemporaryStatusSetups,
					GameMatcher.PermanentStatusSetups));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			{
				List<StatusSetup> combined = new List<StatusSetup>(
					weapon.PermanentStatusSetups.Concat(
						weapon.TemporaryStatusSetups.Select(t => t.Setup)
					));

				ammo.AddStatusSetups(combined);
			}
		}
	}
}