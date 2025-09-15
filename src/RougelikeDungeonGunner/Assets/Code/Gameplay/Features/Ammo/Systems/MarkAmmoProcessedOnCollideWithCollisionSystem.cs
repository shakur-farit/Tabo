using System.Collections.Generic;
using Code.Gameplay.Features.SpecialEffect.Factory;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class MarkAmmoProcessedOnCollideWithCollisionSystem : IExecuteSystem
	{
		private readonly ISpecialEffectsFactory _factory;
		private readonly IGroup<GameEntity> _ammo;
		private readonly List<GameEntity> _buffer = new(32);

		public MarkAmmoProcessedOnCollideWithCollisionSystem(GameContext game, ISpecialEffectsFactory factory)
		{
			_factory = factory;
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.CollisionInFront));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			{
				ammo.isProcessed = true;

				if (ammo.hasSpecialEffectTypeId)
					_factory.CreateSpecialEffect(ammo.SpecialEffectTypeId, ammo.WorldPosition);
			}
		}
	}
}