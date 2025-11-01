using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.SpecialEffect.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
  public class CreatePoisonSpecialEffectSystem : IExecuteSystem
  {
	  private readonly List<GameEntity> _buffer = new(32);

	  private readonly GameContext _game;
	  private readonly ISpecialEffectsFactory _factory;
	  private readonly IGroup<GameEntity> _statuses;

	  public CreatePoisonSpecialEffectSystem(GameContext game, ISpecialEffectsFactory factory)
    {
	    _game = game;
	    _factory = factory;
	    _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Status,
          GameMatcher.Poison,
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

	      GameEntity effect = _factory.CreateSpecialEffect(SpecialEffectTypeId.Poison, target.WorldPosition);

        Debug.Log(effect);

	      effect
		      .AddTargetId(status.TargetId)
		      .With(x => x.isSpecialEffectApplied = true)
		      .With(x => x.isPoisonSpecialEffect = true)
		      ;
      }
    }
  }
}