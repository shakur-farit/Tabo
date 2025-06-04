using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Progress.Data;
using Code.Progress.Provider;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public class WeaponFactory : IWeaponFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;
		private readonly IProgressProvider _progressProvider;

		public WeaponFactory(
			IIdentifierService identifier, 
			IStaticDataService staticDataService,
			IProgressProvider progressProvider)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
			_progressProvider = progressProvider;
		}

		public GameEntity CreateWeapon(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId)
		{
			switch (weaponTypeId)
			{
				case WeaponTypeId.Pistol:
					return CreatePistol(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.Machinegun:
					return CreateMachinegun(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.Sniper:
					return CreateSniper(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.Shotgun:
					return CreateShotgun(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.LaserBlaster:
					return CreateLaserBlaster(weaponTypeId, parent, at, ownerId);
			}

			throw new Exception($"Weapon for {weaponTypeId} type was not found");
		}

		private GameEntity CreatePistol(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isPistol = true)
			;

		private GameEntity CreateRevolver(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isRevolver = true)
		;

		private GameEntity CreateShotgun(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isShotgun = true)
		;

		private GameEntity CreateAutomaticPistol(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isAutomaticPistol = true)
		;
		private GameEntity CreateMachinegun(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isMachinegun = true)
		;

		private GameEntity CreateSniper(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isSniper = true)
		;

		private GameEntity CreatePlasmaGun(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isPlasmaGun = true)
		;

		private GameEntity CreateLaserBlaster(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isLaserBlaster = true)
		;

		private GameEntity CreateRocketLauncher(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isRocketLauncher = true)
		;

		private GameEntity CreateWeaponEntity(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId)
		{
			WeaponConfig config = _staticDataService.GetWeaponConfig(weaponTypeId);
			WeaponData data = GetWeaponData(config);

			Debug.Log($"{data.Cooldown} / {data.MaxSpreadAngle}");

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWeaponTypeId(weaponTypeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddViewParent(parent)
					.AddWeaponOwnerId(ownerId)
					.AddWorldPosition(at)
					.AddRadius(data.FireRange)
					.AddMinPelletsSpreadAngle(data.MinSpreadAngle)
					.AddMaxPelletsSpreadAngle(data.MaxSpreadAngle)
					.AddCooldown(data.Cooldown)
					.AddMaxWeaponEnchantsCount(data.MaxEnchantsCount)
					.With(x => x.isWeapon = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isMagazineNotEmpty = true)
					.With(x => x.isReadyToShoot = true)
					.With(x => x.AddMultiPellet(config.PelletCount), when: config.PelletCount > 1)
					.With(x => x.AddPrechargeTime(data.PrechargingTime), when: data.PrechargingTime > 0)
					.With(x => x.AddPrechargeTimeLeft(data.PrechargingTime), when: data.PrechargingTime > 0)
					.With(x => x.AddMagazineSize(data.MagazineSize), when: config.isInfinityAmmo == false)
					.With(x => x.isInfinityAmmo = true, when: config.isInfinityAmmo)
					.With(x => x.AddCurrentAmmoCount(data.MagazineSize), when: config.isInfinityAmmo == false)
					.With(x => x.AddReloadTime(data.ReloadTime), when: data.ReloadTime > 0 && config.isInfinityAmmo == false)
					.With(x => x.AddReloadTimeLeft(data.ReloadTime), when: data.ReloadTime > 0 && config.isInfinityAmmo == false)
					.With(x => x.AddEffectSetups(data.EffectSetups), when: data.EffectSetups.IsNullOrEmpty() == false)
					.With(x => x.AddStatusSetups(data.StatusSetups), when: data.StatusSetups.IsNullOrEmpty() == false)
					.PutOnCooldown()
				;
		}

		private WeaponData GetWeaponData(WeaponConfig config)
		{
			_progressProvider.WeaponData.ResetWeaponData(config);
			return _progressProvider.WeaponData;
		}
	}
}