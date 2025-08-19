using Code.Gameplay.Features.Ammo.Configs;
using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Ammo.Registrars
{
	public class AmmoSpriteRenderer : EntityComponentRegistrar
	{
		[SerializeField] private SpriteRenderer _spriteRenderer;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) => 
			_staticDataService = staticDataService;

		public override void RegisterComponents()
		{
			AmmoConfig config = _staticDataService.GetAmmoConfig(Entity.AmmoTypeId);

			_spriteRenderer.sprite = config.Sprite;
			_spriteRenderer.color = config.Color;
			
			Entity.AddSpriteRenderer(_spriteRenderer);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasSpriteRenderer)
				Entity.RemoveSpriteRenderer();
		}
	}
}