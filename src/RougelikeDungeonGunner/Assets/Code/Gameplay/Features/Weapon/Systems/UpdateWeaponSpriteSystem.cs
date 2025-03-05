using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class UpdateWeaponSpriteSystem : IExecuteSystem
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _weapons;

		public UpdateWeaponSpriteSystem(GameContext game, IStaticDataService staticDataService)
		{
			_staticDataService = staticDataService;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponSpriteRenderer));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				weapon.WeaponSpriteRenderer.sprite = _staticDataService.GetWeaponConfig(WeaponId.Pistol).WeaponSprite;
			}
		}
	}
}