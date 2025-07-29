using Code.Infrastructure.View.Registrars;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Dungeon.Registrars
{
	public class CollisionTilemapRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Tilemap _collisionTilemap;
		[SerializeField] private Sprite _validSprite;

		public override void RegisterComponents()
		{
			Entity
				.AddCollisionTilemap(_collisionTilemap)
				.AddValidSprite(_validSprite);
		}

		public override void UnregisterComponents()
		{
			if(Entity.hasCollisionTilemap)
				Entity.RemoveCollisionTilemap();
		}
	}
}