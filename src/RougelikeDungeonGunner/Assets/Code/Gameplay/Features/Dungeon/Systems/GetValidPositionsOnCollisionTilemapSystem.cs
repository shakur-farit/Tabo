using System.Collections.Generic;
using Assets.Code.Gameplay.Features.AStar;
using Entitas;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Levels
{
	public class GetValidPositionsOnCollisionTilemapSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _dungeons;

		public GetValidPositionsOnCollisionTilemapSystem(GameContext game)
		{
			_dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CollisionTilemap,
					GameMatcher.ValidSprite)
				.NoneOf(GameMatcher.ValidPositions));
		}

		public void Execute()
		{
			foreach (GameEntity dungeon in _dungeons.GetEntities(_buffer))
			{
				dungeon.AddValidPositions(GetValidPositions(dungeon.CollisionTilemap, dungeon.ValidSprite));
			}
		}

		private List<Vector2Int> GetValidPositions(Tilemap collisionTilemap, Sprite validSprite)
		{
			List<Vector2Int> validPositions = new();

			foreach (Vector3Int position3d in GetTilesMatchingSprite(collisionTilemap, validSprite))
				validPositions.Add((Vector2Int)position3d);

			DrawValidPositions(validPositions, Color.cyan);

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

		private void DrawValidPositions(List<Vector2Int> positions, Color color)
		{
			foreach (Vector2Int pos in positions)
			{
				Vector3 worldPos = new Vector3(pos.x + 0.5f, pos.y + 0.5f, 0); 
				Debug.DrawRay(worldPos, Vector3.up * 0.25f, color.gamma, 60f);
			}
		}
	}
}