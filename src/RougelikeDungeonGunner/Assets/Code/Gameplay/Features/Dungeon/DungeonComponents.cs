using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Dungeon
{
	[Game] public class Dungeon : IComponent { }
	[Game] public class DungeonTypeIdComponent : IComponent { public DungeonTypeId Value; }

	[Game] public class HeroStartPosition : IComponent { public Vector2 Value; }
	[Game] public class CollisionTilemap : IComponent { public Tilemap Value; }

	[Game] public class EnemySpawnValidSprite : IComponent { public Sprite Value; }
	[Game] public class EnemySpawnValidPositions : IComponent { public List<Vector2Int> Value; }

	[Game] public class WallDestroyableDecorationTilemap : IComponent { public Tilemap Value; }
	[Game] public class FloorDestroyableDecorationTilemap : IComponent { public Tilemap Value; }
	[Game] public class WallDestroyableDecorationSprite : IComponent { public Sprite Value; }
	[Game] public class FloorDestroyableDecorationSprite : IComponent { public Sprite Value; }
  [Game] public class WallDestroyableItemValidPositions : IComponent { public List<Vector2Int> Value; }
  [Game] public class FloorDestroyableItemValidPositions : IComponent { public List<Vector2Int> Value; }


  [Game] public class DungeonAvailable : IComponent { }
}