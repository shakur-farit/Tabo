using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Dungeon.Systems
{
  public class GetFloorDestroyableItemValidPositionSystem : IExecuteSystem
  {
    private readonly List<GameEntity> _buffer = new(1);
    private readonly IValidPositionsProvider _validPositionsProvider;
    private readonly IGroup<GameEntity> _dungeons;

    public GetFloorDestroyableItemValidPositionSystem(GameContext game, IValidPositionsProvider validPositionsProvider)
    {
      _validPositionsProvider = validPositionsProvider;
      _dungeons = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.FloorDestroyableDecorationTilemap,
          GameMatcher.FloorDestroyableDecorationSprite)
        .NoneOf(GameMatcher.FloorDestroyableItemValidPositions));
    }

    public void Execute()
    {
      foreach (GameEntity dungeon in _dungeons.GetEntities(_buffer))
      {
        dungeon.AddFloorDestroyableItemValidPositions(
          _validPositionsProvider.GetValidPositions(
            dungeon.FloorDestroyableDecorationTilemap,
            dungeon.FloorDestroyableDecorationSprite));
      }
    }
  }
}