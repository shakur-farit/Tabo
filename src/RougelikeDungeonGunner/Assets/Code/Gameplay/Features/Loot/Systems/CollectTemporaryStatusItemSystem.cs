using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectStatusItemSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public CollectStatusItemSystem(GameContext game)
		{
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected
					//GameMatcher.StatusSetups
					));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			foreach (GameEntity collected in _collected)
			{
				//if (weapon.hasTemporaryStatusSetups)
				//{
				//	foreach (StatusSetup setup in collected.TemporaryStatusSetups.ToList())
				//		if (weapon.TemporaryStatusSetups.Contains(setup) == false)
				//			weapon.TemporaryStatusSetups.Add(setup);
				//}
				//else
				//{
				//	weapon.AddTemporaryStatusSetups(new List<StatusSetup>(collected.TemporaryStatusSetups));
				//}
			}
		}
	}
}