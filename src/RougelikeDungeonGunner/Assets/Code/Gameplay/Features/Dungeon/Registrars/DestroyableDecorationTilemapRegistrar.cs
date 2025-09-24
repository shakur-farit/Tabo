using Code.Infrastructure.View.Registrars;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Dungeon.Registrars
{
	public class DestroyableDecorationTilemapRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Tilemap _wallDestroyableDecorationTilemap;
		[SerializeField] private Tilemap _destroyableDecorationTilemap;
		[SerializeField] private Sprite _destroyableDecorationSprite;
		[SerializeField] private Sprite _wallDestroyableDecorationSprite;


		public override void RegisterComponents()
		{
			Entity
				.AddWallDestroyableDecorationTilemap(_wallDestroyableDecorationTilemap)
				.AddDestroyableDecorationTilemap(_destroyableDecorationTilemap)
				.AddWallDestroyableDecorationSprite(_wallDestroyableDecorationSprite)
				.AddDestroyableDecorationSprite(_destroyableDecorationSprite)
				;
		}

		public override void UnregisterComponents()
		{
			if(Entity.hasWallDestroyableDecorationTilemap)
				Entity.RemoveWallDestroyableDecorationTilemap();

			if (Entity.hasDestroyableDecorationTilemap)
				Entity.RemoveDestroyableDecorationTilemap();

			if(Entity.hasWallDestroyableDecorationSprite)
				Entity.RemoveWallDestroyableDecorationSprite();

			if (Entity.hasDestroyableDecorationSprite)
				Entity.RemoveDestroyableDecorationSprite();
		}
	}
}