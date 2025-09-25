using Entitas;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Dungeon.Systems
{
  public class GetWallDestroyableItemValidPositionSystem : IExecuteSystem
  {
    private readonly List<GameEntity> _buffer = new(1);
    private readonly IValidPositionsProvider _validPositionsProvider;
    private readonly IGroup<GameEntity> _dungeons;

    public GetWallDestroyableItemValidPositionSystem(GameContext game, IValidPositionsProvider validPositionsProvider)
    {
      _validPositionsProvider = validPositionsProvider;
      _dungeons = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.WallDestroyableDecorationTilemap,
          GameMatcher.WallDestroyableDecorationSprite)
        .NoneOf(GameMatcher.WallDestroyableItemValidPositions));
    }

    public void Execute()
    {
      foreach (GameEntity dungeon in _dungeons.GetEntities(_buffer))
      {
        dungeon.AddWallDestroyableItemValidPositions(
          _validPositionsProvider.GetValidPositions(
            dungeon.WallDestroyableDecorationTilemap,
            dungeon.WallDestroyableDecorationSprite));
      }
    }
  }
}