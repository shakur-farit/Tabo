using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class UpdateFirePositionSystem : IExecuteSystem
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _weapons;

		public UpdateFirePositionSystem(GameContext game, IStaticDataService staticDataService)
		{
			_staticDataService = staticDataService;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.FirePositionTransform,
					GameMatcher.Weapon));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
				weapon.FirePositionTransform.localPosition =
					_staticDataService
						.GetWeaponConfig(weapon.WeaponTypeId).FirePosition;
		}
	}
}