using Code.Infrastructure.View.Registrars;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Dungeon.Registrars
{
	public class DestroyableDecorationTilemapRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Tilemap _wallDestroyableDecorationTilemap;
		[SerializeField] private Tilemap _floorDestroyableDecorationTilemap;
		[SerializeField] private Sprite _floorDestroyableDecorationSprite;
		[SerializeField] private Sprite _wallDestroyableDecorationSprite;


		public override void RegisterComponents()
		{
			Entity
				.AddWallDestroyableDecorationTilemap(_wallDestroyableDecorationTilemap)
				.AddFloorDestroyableDecorationTilemap(_floorDestroyableDecorationTilemap)
				.AddWallDestroyableDecorationSprite(_wallDestroyableDecorationSprite)
				.AddFloorDestroyableDecorationSprite(_floorDestroyableDecorationSprite)
				;
		}

		public override void UnregisterComponents()
		{
			if(Entity.hasWallDestroyableDecorationTilemap)
				Entity.RemoveWallDestroyableDecorationTilemap();

			if (Entity.hasFloorDestroyableDecorationTilemap)
				Entity.RemoveFloorDestroyableDecorationTilemap();

			if(Entity.hasWallDestroyableDecorationSprite)
				Entity.RemoveWallDestroyableDecorationSprite();

			if (Entity.hasFloorDestroyableDecorationSprite)
				Entity.RemoveFloorDestroyableDecorationSprite();
		}
	}
}