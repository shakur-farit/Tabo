using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Ammo.Registrars
{
	public class AuraSpriteRenderer : EntityComponentRegistrar
	{
		[SerializeField] private SpriteRenderer _spriteRenderer;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) =>
			_staticDataService = staticDataService;

		public override void RegisterComponents()
		{
			AuraConfig config = _staticDataService.GetAuraConfig(Entity.AuraTypeId);

			_spriteRenderer.sprite = config.Sprite;
			_spriteRenderer.material = config.Material;

			Color color = _spriteRenderer.color;
			color.a = config.Alpha;
			_spriteRenderer.color = color;

			Entity.AddSpriteRenderer(_spriteRenderer);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasSpriteRenderer)
				Entity.RemoveSpriteRenderer();
		}
	}
}