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
					GameMatcher.SpriteRenderer,
					GameMatcher.Weapon,
					GameMatcher.WeaponTypeId));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
				weapon.SpriteRenderer.sprite = _staticDataService.GetWeaponConfig(weapon.WeaponTypeId).WeaponSprite;
		}
	}
}