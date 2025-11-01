using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
	public class MarkSpecialEffectDestructedSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(32);

		private readonly IGroup<GameEntity> _statuses;
		private readonly IGroup<GameEntity> _specialEffects;

		public MarkSpecialEffectDestructedSystem(GameContext game)
		{
			_statuses = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Status,
					GameMatcher.Unapplied,
					GameMatcher.Id,
					GameMatcher.SpecialEffectApplied));

			_specialEffects = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.SpecialEffect,
					GameMatcher.ProducerId,
					GameMatcher.SpecialEffectApplied));
		}

		public void Execute()
		{
			foreach (GameEntity status in _statuses)
      foreach (GameEntity specialEffect in _specialEffects.GetEntities(_buffer))
      {
				if(status.Id == specialEffect.ProducerId)
         specialEffect.isDestructed = true;
      }
    }
	}
}