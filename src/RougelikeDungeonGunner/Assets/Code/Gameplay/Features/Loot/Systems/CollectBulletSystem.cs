using Code.Gameplay.Features.Weapon.Services;
using Code.Sounds.SoundEffects.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectBulletSystem : IExecuteSystem
	{
		private readonly IAmmoCountProvider _currentAmmo;
		private readonly ISoundEffectFactory _soundEffectFactory;
    private readonly IWeaponReloadService _weaponReloadService;
    private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _holders;

		public CollectBulletSystem(
			GameContext game,
			IAmmoCountProvider currentAmmo,
			ISoundEffectFactory soundEffectFactory,
      IWeaponReloadService weaponReloadService)
		{
			_currentAmmo = currentAmmo;
			_soundEffectFactory = soundEffectFactory;
      _weaponReloadService = weaponReloadService;
      _collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.LootValue,
					GameMatcher.BulletLoot));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroWeapon,
					GameMatcher.CurrentAmmoCount,
					GameMatcher.MaxAmmoCount)
				.NoneOf(GameMatcher.HeroRocketLauncher));

			_holders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.AmmoHolder));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity collected in _collected)
			foreach (GameEntity holder in _holders)
			{
				weapon.ReplaceCurrentAmmoCount(weapon.CurrentAmmoCount + collected.LootValue);

				if (weapon.CurrentAmmoCount > weapon.MaxAmmoCount)
					weapon.ReplaceCurrentAmmoCount(weapon.MaxAmmoCount);

				_currentAmmo.SetCurrentAmmoCount(weapon.CurrentAmmoCount);

        if (weapon.CurrentAmmoCountInMagazine <= 0)
        {
#if UNITY_EDITOR
          _weaponReloadService.StartReloading();
#elif UNITY_STANDALONE
            weapon.isReloading = true;
#elif UNITY_ANDROID || UNITY_IOS
            _weaponReloadService.StartReloading();

#elif UNITY_WEBGL
            if (Application.isMobilePlatform)
						  _weaponReloadService.StartReloading();
            else
                weapon.isReloading = true;
#else
            weapon.isReloading = true;
#endif

          weapon.isReadyToShoot = true;
          weapon.isWeaponNotEmpty = true;
        }
        
        if (weapon.isReloading == false)
          holder.AmmoHolder.UpdateAmmoUICount(weapon.CurrentAmmoCount);

				if (collected.hasSoundEffectTypeId)
					_soundEffectFactory.CreateSoundEffect(collected.SoundEffectTypeId);
			}
		}
	}
}