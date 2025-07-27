using Code.Infrastructure.View.Registrars;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Code.Gameplay.Features.Levels
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