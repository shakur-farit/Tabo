using Code.Common.Entity;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Registrars
{
	public class WeaponSpriteRendererRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private SpriteRenderer _spriteRenderer;

		public override void RegisterComponents()
		{
			CreateEntity.Empty()
				.AddWeaponSpriteRenderer(_spriteRenderer);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasWeaponSpriteRenderer)
				Entity.RemoveWeaponSpriteRenderer();
		}
	}
}