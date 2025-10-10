using System.Collections.Generic;
using Code.Gameplay.Features.Weapon.Services;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class SetHeroWeaponReloadingByPressButtonSystem : IExecuteSystem
	{
    private readonly IWeaponReloadService _reloadService;
    private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public SetHeroWeaponReloadingByPressButtonSystem(GameContext game, IWeaponReloadService reloadService)
    {
      _reloadService = reloadService;
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
				if (_reloadService.IsReloading)
				{
					weapon.isMagazineNotEmpty = false;
					weapon.isReloading = true;

					_reloadService.StopReloading();
				}
			}
		}
	}
}