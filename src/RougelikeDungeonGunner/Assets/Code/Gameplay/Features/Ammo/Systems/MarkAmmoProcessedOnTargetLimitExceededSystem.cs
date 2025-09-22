using System.Collections.Generic;
using Assets.Code.Gameplay.Features.SpecialEffect.Factory;
using Entitas;

namespace Assets.Code.Gameplay.Features.Ammo.Systems
{
	public class MarkAmmoProcessedOnTargetLimitExceededSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(32);

		private readonly IGroup<GameEntity> _ammo;
		private readonly ISpecialEffectsFactory _factory;

		public MarkAmmoProcessedOnTargetLimitExceededSystem(GameContext game, ISpecialEffectsFactory factory)
		{
			_factory = factory;
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.TargetLimit,
					GameMatcher.ProcessedTargets));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			{
				if (ammo.ProcessedTargets.Count >= ammo.TargetLimit)
				{
					ammo.isProcessed = true;

					if (ammo.hasSpecialEffectTypeId)
						_factory.CreateSpecialEffect(ammo.SpecialEffectTypeId, ammo.WorldPosition);
				}
			}
		}
	}
}