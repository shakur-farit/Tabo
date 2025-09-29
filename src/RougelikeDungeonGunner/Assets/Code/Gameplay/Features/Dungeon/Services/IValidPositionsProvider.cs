using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Dungeon.Services
{
  public interface IValidPositionsProvider
  {
    List<Vector2Int> GetValidPositions(Tilemap tilemap, Sprite validSprite);
  }
}