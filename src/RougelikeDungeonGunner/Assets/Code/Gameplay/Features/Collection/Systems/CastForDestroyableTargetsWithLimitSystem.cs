using Code.Gameplay.Common.Physics;
using Entitas;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Collection.Systems
{
  public class CastForDestroyableTargetsWithLimitSystem : IExecuteSystem, ITearDownSystem
  {
    private readonly List<GameEntity> _buffer = new(128);
    private GameEntity[] _targetCastBuffer = new GameEntity[128];

    private readonly IPhysicsService _physicsService;
    private readonly IGroup<GameEntity> _entities;

    public CastForDestroyableTargetsWithLimitSystem(GameContext game, IPhysicsService physicsService)
    {
      _physicsService = physicsService;
      _entities = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.DestroyableTargetsBuffer,
          GameMatcher.DestroyableCollectRadius,
          GameMatcher.DestroyableTargetLayerMask,
          GameMatcher.WorldPosition,
          GameMatcher.TargetLimit,
          GameMatcher.ReadyToCollectTargets));
    }

    public void Execute()
    {
      foreach (GameEntity entity in _entities.GetEntities(_buffer))
      {
        for (int i = 0; i < Math.Min(TargetsCountInRadius(entity), entity.TargetLimit); i++)
        {
          int targetId = _targetCastBuffer[i].Id;

          if (AlreadyProcessed(entity, targetId) == false)
          {
            entity.DestroyableTargetsBuffer.Add(targetId);
            entity.ProcessedTargets.Add(targetId);
          }
        }

        if (entity.isCollectTargetsContinuously == false)
          entity.isReadyToCollectTargets = false;
      }
    }

    private bool AlreadyProcessed(GameEntity entity, int targetId) =>
      entity.ProcessedTargets.Contains(targetId);

    private int TargetsCountInRadius(GameEntity entity)
    {
      Vector2 center = entity.WorldPosition;

      if (entity.hasCastStartPositionTransform)
        center = entity.CastStartPositionTransform.position;

      return _physicsService
        .CircleCastNonAlloc(center, entity.DestroyableCollectRadius, entity.DestroyableTargetLayerMask, _targetCastBuffer);
    }

    public void TearDown() =>
      _targetCastBuffer = null;
  }
}