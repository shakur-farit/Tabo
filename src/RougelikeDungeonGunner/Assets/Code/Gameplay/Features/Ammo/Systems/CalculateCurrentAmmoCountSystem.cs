using System.Collections.Generic;
using Code.Gameplay.Features.Weapon.Services;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CalculateCurrentAmmoCountSystem : IExecuteSystem
	{
    private readonly List<GameEntity> _buffer = new(1);

    private readonly IGroup<GameEntity> _weapons;
    private readonly IAmmoCountProvider _ammoCountProvider;

    public CalculateCurrentAmmoCountSystem(GameContext game, IAmmoCountProvider ammoCountProvider)
    {
      _ammoCountProvider = ammoCountProvider;
      _weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.MagazineSize,
					GameMatcher.CurrentAmmoCountInMagazine,
					GameMatcher.CurrentAmmoCount,
					GameMatcher.WeaponNotEmpty,
					GameMatcher.MagazineNotEmpty,
          GameMatcher.Shot));
    }

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				Debug.Log(weapon.CurrentAmmoCountInMagazine);

				weapon.ReplaceCurrentAmmoCountInMagazine(weapon.CurrentAmmoCountInMagazine - 1);
				weapon.ReplaceCurrentAmmoCount(weapon.CurrentAmmoCount - 1);

				_ammoCountProvider.SetCurrentAmmoCount(weapon.CurrentAmmoCount);

        if (weapon.CurrentAmmoCount <= 0)
        {
          weapon.isWeaponNotEmpty = false;
					continue;
        }

				if (weapon.CurrentAmmoCountInMagazine <= 0)
				{
					weapon.isMagazineNotEmpty = false;
					weapon.isReloading = true;
				}
			}
		}
	}
}