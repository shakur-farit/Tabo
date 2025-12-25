using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.SpecialEffect.Factory;
using Entitas;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
  public class CreatePoisonBossSpecialEffectSystem : IExecuteSystem
  {
    private readonly List<GameEntity> _buffer = new(32);

    private readonly GameContext _game;
    private readonly ISpecialEffectsFactory _factory;
    private readonly IGroup<GameEntity> _statuses;

    public CreatePoisonBossSpecialEffectSystem(GameContext game, ISpecialEffectsFactory factory)
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

        if (target.isBoss == false)
          continue;

        GameEntity effect = _factory.CreateSpecialEffect(SpecialEffectTypeId.PoisonBoss, target.WorldPosition);

        effect
          .AddProducerId(status.Id)
          .AddTargetId(status.TargetId)
          .With(x => x.isFollowerSpecialEffect = true)
          .With(x => x.isSpecialEffectApplied = true)
          ;
      }
    }
  }
}