using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Destroyable.Systems
{
  public class MarkDestructDestroyedDestroyableItemEntitySystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _destroyables;
    private readonly List<GameEntity> _buffer = new(32);

    public MarkDestructDestroyedDestroyableItemEntitySystem(GameContext game)
    {
      _destroyables = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.DestroyableItem,
          GameMatcher.Destroyed));
    }

    public void Execute()
    {
      foreach (GameEntity destroyable in _destroyables.GetEntities(_buffer)) 
        destroyable.isDestructed = true;
    }
  }
}