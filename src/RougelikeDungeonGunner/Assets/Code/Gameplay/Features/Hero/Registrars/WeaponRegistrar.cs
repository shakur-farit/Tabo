using Code.Common.Entity;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Registrars
{
	public class WeaponRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private Transform _firePosiotionTransform;
		[SerializeField] private SpriteRenderer _spriteRenderer;

		public override void RegisterComponents()
		{
			CreateEntity.Empty()
				.AddFirePosition(_firePosiotionTransform.position)
				.AddWeaponSprite(_spriteRenderer.sprite);
		}

		public override void UnregisterComponents()
		{
		}
	}
}