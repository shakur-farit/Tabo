using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Common.Physics;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Collection.Systems
{
  public class CastForDestroyableTargetsWithNoLimitSystem : IExecuteSystem
  {
    private readonly List<GameEntity> _buffer = new(128);

    private readonly IPhysicsService _physicsService;
    private readonly IGroup<GameEntity> _ready;

    public CastForDestroyableTargetsWithNoLimitSystem(GameContext game, IPhysicsService physicsService)
    {
      _physicsService = physicsService;
      _ready = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.DestroyableTargetsBuffer,
          GameMatcher.DestroyableCollectRadius,
          GameMatcher.DestroyableTargetLayerMask,
          GameMatcher.WorldPosition,
          GameMatcher.ReadyToCollectTargets)
        .NoneOf(GameMatcher.TargetLimit));
    }

    public void Execute()
    {

      foreach (GameEntity ready in _ready.GetEntities(_buffer))
      {
        ready.DestroyableTargetsBuffer.AddRange(TargetsInRadius(ready));

        if (ready.isCollectTargetsContinuously == false)
          ready.isReadyToCollectTargets = false;
      }
    }

    private IEnumerable<int> TargetsInRadius(GameEntity entity)
    {
      Vector2 center = entity.WorldPosition;

      if (entity.hasCastStartPositionTransform)
        center = entity.CastStartPositionTransform.position;

      return _physicsService
        .CircleCast(center, entity.DestroyableCollectRadius, entity.DestroyableTargetLayerMask)
        .Select(x => x.Id);
    }
  }
}