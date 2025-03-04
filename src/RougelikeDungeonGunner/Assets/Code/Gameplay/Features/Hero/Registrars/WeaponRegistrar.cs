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
				.AddFirePositionTransform(_firePosiotionTransform)
				.AddWeaponSpriteRenderer(_spriteRenderer)
				;

		}

		public override void UnregisterComponents()
		{
		}
	}
}