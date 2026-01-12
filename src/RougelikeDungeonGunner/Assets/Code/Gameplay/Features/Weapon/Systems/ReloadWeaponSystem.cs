using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Weapon.Services;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class ReloadWeaponSystem : IExecuteSystem
	{
		private readonly ITimeService _time;
    private readonly IWeaponReloadService _reloadService;
    private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public ReloadWeaponSystem(GameContext game, ITimeService time, IWeaponReloadService reloadService)
		{
			_time = time;
      _reloadService = reloadService;
      _weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.MagazineSize,
					GameMatcher.CurrentAmmoCount,
					GameMatcher.WeaponNotEmpty,
					GameMatcher.ReloadTime,
					GameMatcher.ReloadTimeLeft,
					GameMatcher.Reloading));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
        if (weapon.ReloadTimeLeft > 0)
				{
					weapon.ReplaceReloadTimeLeft(weapon.ReloadTimeLeft - _time.DeltaTime);
				}
				else
				{
          weapon.ReplaceCurrentAmmoCountInMagazine(weapon.CurrentAmmoCount < weapon.MagazineSize
            ? weapon.CurrentAmmoCount
            : weapon.MagazineSize);

          weapon.ReplaceReloadTimeLeft(weapon.ReloadTime);
					weapon.isMagazineNotEmpty = true;
					weapon.isReloading = false;

#if UNITY_EDITOR
          _reloadService.StopReloading();
#elif UNITY_ANDROID || UNITY_IOS
          _reloadService.StopReloading();
#elif UNITY_WEBGL
          if (Application.isMobilePlatform)
						_reloadService.StopReloading();
#endif
				}
			}
		}
	}
}