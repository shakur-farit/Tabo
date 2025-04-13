using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Statuses.Applier;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectStatusItemSystem : IExecuteSystem
	{
		private readonly IStatusApplier _statusApplier;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _ammo;

		public CollectStatusItemSystem(GameContext game, IStatusApplier statusApplier)
		{
			_statusApplier = statusApplier;
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.StatusSetups));

			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Id,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo)
			foreach (GameEntity collected in _collected)
			foreach (StatusSetup statusSetup in collected.StatusSetups)
			{
				_statusApplier.ApplyStatus(statusSetup, ammo.Id, ammo.Id);
				Debug.Log("Here");
			}
		}
	}
}