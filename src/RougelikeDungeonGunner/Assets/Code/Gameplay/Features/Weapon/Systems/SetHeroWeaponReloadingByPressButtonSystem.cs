using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class SetHeroWeaponReloadingByPressButtonSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public SetHeroWeaponReloadingByPressButtonSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon,
					GameMatcher.MagazineSize,
					GameMatcher.ReloadTime,
					GameMatcher.ReloadTimeLeft)
				.NoneOf(GameMatcher.Reloading));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				if (UnityEngine.Input.GetKeyDown(KeyCode.R))
				{
					weapon.isMagazineNotEmpty = false;
					weapon.isReloading = true;
				}
			}
		}
	}
}