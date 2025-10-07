using Entitas;
using System.Collections.Generic;

namespace Code.Gameplay.Features.Destroyable.Systems
{
  public class MarkDestroyedDestroyableItemOnAnimationEndSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _destroyables;
    private readonly List<GameEntity> _buffer = new(32);

    public MarkDestroyedDestroyableItemOnAnimationEndSystem(GameContext game)
    {
      _destroyables = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.DestroyableAnimator,
          GameMatcher.Destroying));
    }

    public void Execute()
    {
      foreach (GameEntity destroyable in _destroyables.GetEntities(_buffer))
      {
        if (destroyable.DestroyableAnimator.IsDestroyed())
        {
          destroyable.isDestroyed = true;
          destroyable.DestroyableAnimator.ResetAnimator();
        }
      }
    }
  }
}