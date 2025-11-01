using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.SpecialEffect.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
	public class CreateFreezeSpecialEffectSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(32);

		private readonly GameContext _game;
		private readonly ISpecialEffectsFactory _factory;
		private readonly IGroup<GameEntity> _statuses;

		public CreateFreezeSpecialEffectSystem(GameContext game, ISpecialEffectsFactory factory)
		{
			_game = game;
			_factory = factory;
			_statuses = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Status,
					GameMatcher.Freeze,
					GameMatcher.Applied,
					GameMatcher.TargetId)
				.NoneOf(GameMatcher.SpecialEffectApplied));
		}

		public void Execute()
		{
			foreach (GameEntity status in _statuses.GetEntities(_buffer))
			{
				status.isSpecialEffectApplied = true;

				GameEntity target = _game.GetEntityWithId(status.TargetId);

				GameEntity effect = _factory.CreateSpecialEffect(SpecialEffectTypeId.Freeze, target.WorldPosition);

				effect
					.AddTargetId(status.TargetId)
          .AddProducerId(status.Id)
          .With(x => x.isSpecialEffectApplied = true)
					;
			}
		}
	}
}