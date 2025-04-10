using Code.Gameplay.StaticData;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class CalculateMultiPelletCountSystem : IExecuteSystem
	{
		private readonly IStaticDataService _staticDataService;
		private readonly IGroup<GameEntity> _weapons;

		public CalculateMultiPelletCountSystem(GameContext game, IStaticDataService staticDataService)
		{
			_staticDataService = staticDataService;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.MultiPellet));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
				weapon
					.ReplaceMultiPellet(_staticDataService.GetWeaponLevel(weapon.WeaponTypeId, 1).PelletCount);
		}
	}
}