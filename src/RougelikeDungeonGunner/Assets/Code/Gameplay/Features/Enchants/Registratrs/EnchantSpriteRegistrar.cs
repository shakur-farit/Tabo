using Code.Gameplay.StaticData;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Features.Enchants
{
	public class EnchantSpriteRegistrar : EntityComponentRegistrar
	{ 
		[SerializeField] private Image _image;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) =>
			_staticDataService = staticDataService;

		public override void RegisterComponents()
		{
			_image.sprite =
				_staticDataService
					.GetEnchantConfig(Entity.EnchantTypeId).Sprite;

			Entity
				.AddSprite(_image.sprite);
		}

		public override void UnregisterComponents()
		{
			if (Entity.hasSprite)
				Entity.RemoveSprite();
		}
	}
}