using Entitas;
using System.Collections.Generic;
using Code.Gameplay.Features.Destroyable.Factory;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Systems
{
  public class CreateWallDestroyableItemReactiveSystem : ReactiveSystem<GameEntity>
  {
    private readonly IDestroyableItemFactory _factory;

    public CreateWallDestroyableItemReactiveSystem(GameContext game, IDestroyableItemFactory factory) : base(game) => 
      _factory = factory;

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
      context.CreateCollector(GameMatcher.WallDestroyableItemValidPositions.Added());

    protected override bool Filter(GameEntity dungeon) => dungeon.hasWallDestroyableItemValidPositions;

    protected override void Execute(List<GameEntity> dungeons)
    {
      foreach (GameEntity dungeon in dungeons)
      foreach (Vector2Int position in dungeon.WallDestroyableItemValidPositions)
        _factory.CreateDestroyableItem(DestroyableItemPlacingTypeId.Wall, (Vector2)position);
    }
  }
}