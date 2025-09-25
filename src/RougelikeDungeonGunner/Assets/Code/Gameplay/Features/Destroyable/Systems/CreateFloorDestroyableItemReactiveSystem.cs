using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Systems
{
  public class CreateFloorDestroyableItemReactiveSystem : ReactiveSystem<GameEntity>
  {
    private readonly IDestroyableItemFactory _factory;

    public CreateFloorDestroyableItemReactiveSystem(GameContext game, IDestroyableItemFactory factory) : base(game) =>
      _factory = factory;

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
      context.CreateCollector(GameMatcher.FloorDestroyableItemValidPositions.Added());

    protected override bool Filter(GameEntity dungeon) => dungeon.hasFloorDestroyableItemValidPositions;

    protected override void Execute(List<GameEntity> dungeons)
    {
      foreach (GameEntity dungeon in dungeons)
      foreach (Vector2Int position in dungeon.FloorDestroyableItemValidPositions)
        _factory.CreateDestroyableItem(DestroyableItemPlacingTypeId.Wall, (Vector2)position);
    }
  }
}