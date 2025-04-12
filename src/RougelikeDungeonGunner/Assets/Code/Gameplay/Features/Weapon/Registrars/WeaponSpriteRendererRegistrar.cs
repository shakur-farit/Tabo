using System;
using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Weapon.Registrars
{
	public class WeaponSpriteRendererRegistrar : EntityComponentRegistrar
	{
		[SerializeField] private SpriteRenderer _spriteRenderer;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) =>
			_staticDataService = staticDataService;

		public override void RegisterComponents()
		{
			_spriteRenderer.sprite =
				_staticDataService
					.GetWeaponConfig(Entity.WeaponTypeId).Sprite;

			Entity
				.AddWeaponSpriteRenderer(_spriteRenderer);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasWeaponSpriteRenderer)
				Entity.RemoveWeaponSpriteRenderer();
		}
	}
}