using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.UIRoot.Factory
{
	public class HeroUI : MonoBehaviour
	{
		[SerializeField] private SpriteRenderer _handSpriteRenderer;
		[SerializeField] private SpriteRenderer _weaponSpriteRenderer;
		[SerializeField] private Animator _animator;

		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(IStaticDataService staticDataService) => 
			_staticDataService = staticDataService;

		public void UpdateHeroUI(HeroConfig config)
		{
			_handSpriteRenderer.sprite = config.HandSprite;
			_animator.runtimeAnimatorController = config.AnimatorController;

			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(config.StartWeapon);
			_weaponSpriteRenderer.sprite = weaponConfig.Sprite;
		}
	}
}