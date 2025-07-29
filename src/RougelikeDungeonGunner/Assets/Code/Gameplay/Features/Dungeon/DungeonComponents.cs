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
	[Game] public class ValidSprite : IComponent { public Sprite Value; }
	[Game] public class ValidPositions : IComponent { public List<Vector2Int> Value; }
	
	[Game] public class DungeonAvailable : IComponent { }
}