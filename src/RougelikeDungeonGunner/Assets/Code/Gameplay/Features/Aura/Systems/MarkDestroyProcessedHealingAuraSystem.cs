using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo
{
	public class MarkDestroyProcessedHealingAuraSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _aurasBuffer = new(32);
		private readonly List<GameEntity> _holdersBuffer = new(32);

		private readonly IGroup<GameEntity> _auras;
		private readonly IGroup<GameEntity> _auraHolders;

		public MarkDestroyProcessedHealingAuraSystem(GameContext game)
		{
			_auras = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Aura,
					GameMatcher.ProducerId,
					GameMatcher.HealingAura,
					GameMatcher.Processed));

			_auraHolders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HealingAuraApplied,
					GameMatcher.Id));
		}

		public void Execute()
		{
			foreach (GameEntity aura in _auras.GetEntities(_aurasBuffer))
			foreach (GameEntity holder in _auraHolders.GetEntities(_holdersBuffer))
			{
				if (aura.ProducerId != holder.Id)
					continue;

				holder.isHealingAuraApplied = false;
				aura.isDestructed = true;

			}
		}
	}
}