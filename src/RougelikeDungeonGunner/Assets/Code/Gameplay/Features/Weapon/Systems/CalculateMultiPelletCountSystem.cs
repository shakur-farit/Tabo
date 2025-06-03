using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Progress.Provider;
using Entitas;
using UnityEngine;

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
			{
				WeaponConfig config = _staticDataService.GetWeaponConfig(weapon.WeaponTypeId);

				weapon
					.ReplaceMultiPellet(config.PelletCount);
			}
		}
	}
}