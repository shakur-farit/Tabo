using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Loot.Registrars
{
	public class LootSpriteRendererRegistrar : EntityComponentRegistrar
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
					.GetLootConfig(Entity.LootTypeId).Sprite;

			Entity
				.AddSpriteRenderer(_spriteRenderer);
		}

		public override void UnregisterComponents()
		{
			if(Entity.hasSpriteRenderer)
				Entity.RemoveSpriteRenderer();
		}
	}
}