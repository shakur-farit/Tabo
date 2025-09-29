using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Dungeon.Services
{
  public class ValidPositionsProvider : IValidPositionsProvider
  {
    public List<Vector2Int> GetValidPositions(Tilemap tilemap, Sprite validSprite)
    {
      List<Vector2Int> validPositions = new();

      foreach (Vector3Int position3d in GetTilesMatchingSprite(tilemap, validSprite))
        validPositions.Add((Vector2Int)position3d);

      return validPositions;
    }

    private List<Vector3Int> GetTilesMatchingSprite(Tilemap tilemap, Sprite validSprite)
    {
      List<Vector3Int> positions = new();
      BoundsInt bounds = tilemap.cellBounds;

      for (int x = bounds.xMin; x < bounds.xMax; x++)
      {
        for (int y = bounds.yMin; y < bounds.yMax; y++)
        {
          Vector3Int pos = new(x, y, 0);
          TileBase tileBase = tilemap.GetTile(pos);

          if (tileBase is Tile tile && tile.sprite == validSprite)
            positions.Add(pos);
        }
      }

      return positions;
    }
  }
}