using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class MarkAmmoProcessedOnCollideWithCollisionSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;
		private readonly List<GameEntity> _buffer = new(32);

		public MarkAmmoProcessedOnCollideWithCollisionSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.CollisionInFront));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer)) 
				ammo.isProcessed = true;
		}
	}
}