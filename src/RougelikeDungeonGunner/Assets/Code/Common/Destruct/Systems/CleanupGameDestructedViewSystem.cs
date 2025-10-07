using Code.Infrastructure.ObjectPool.Services;
using Code.Infrastructure.View;
using Entitas;
using UnityEngine;

namespace Code.Common.Destruct.Systems
{
  public class CleanupGameDestructedViewSystem : ICleanupSystem
  {
    private readonly IObjectPoolService _objectPool;
    private readonly IGroup<GameEntity> _entities;

    public CleanupGameDestructedViewSystem(GameContext game, IObjectPoolService objectPool)
    {
      _objectPool = objectPool;
      _entities = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Destructed,
          GameMatcher.View));
    }

    public void Cleanup()
    {
      foreach (GameEntity entity in _entities)
      {
        IEntityView view = entity.View;

        entity.View.ReleaseEntity();

        if (entity.hasViewPrefab)
          _objectPool.Return(entity.ViewPrefab, view.EntityBehaviourObject);
      }
    }
  }
}