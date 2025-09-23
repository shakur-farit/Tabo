using System.Collections.Generic;
using Code.Gameplay.Features.Collection;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class FinalizeProcessedAmmoSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;
		private readonly List<GameEntity> _buffer = new(32);

		public FinalizeProcessedAmmoSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.Processed));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			{
				ammo.RemoveTargetCollectionComponents();
				ammo.isDestructed = true;
			}
		}
	}
}