using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Levels
{
	public class GetValidPositionsOnCollisionTilemapSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _dungeons;

		public GetValidPositionsOnCollisionTilemapSystem(GameContext game)
		{
			_dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CollisionTilemap,
					GameMatcher.ValidSprite));
		}

		public void Execute()
		{
			foreach (GameEntity dungeon in _dungeons)
				dungeon.ReplaceValidPositions(GetValidPositions(dungeon.CollisionTilemap, dungeon.ValidSprite));
		}

		private List<Vector2> GetValidPositions(Tilemap collisionTilemap, Sprite validSprite)
		{
			List<Vector2> validPositions = new();

			foreach (Vector3Int position3d in GetTilesMatchingSprite(collisionTilemap, validSprite))
			{
				Vector3 pos3d = collisionTilemap.CellToWorld(position3d);
				Vector2 pos2d = new(pos3d.x, pos3d.y);
				validPositions.Add(pos2d);
			}

			return validPositions;
		}

		private List<Vector3Int> GetTilesMatchingSprite(Tilemap collisionTilemap, Sprite validSprite)
		{
			List<Vector3Int> positions = new();
			BoundsInt bounds = collisionTilemap.cellBounds;

			for (int x = bounds.xMin; x < bounds.xMax; x++)
			{
				for (int y = bounds.yMin; y < bounds.yMax; y++)
				{
					Vector3Int pos = new(x, y, 0);
					TileBase tileBase = collisionTilemap.GetTile(pos);

					if (tileBase is Tile tile && tile.sprite == validSprite)
						positions.Add(pos);
				}
			}

			return positions;
		}
	}
}