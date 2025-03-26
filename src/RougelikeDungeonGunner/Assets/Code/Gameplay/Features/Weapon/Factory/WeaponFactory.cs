using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System;
using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public class WeaponFactory : IWeaponFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public WeaponFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateWeapon(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at)
		{
			switch (weaponTypeId)
			{
				case WeaponTypeId.Pistol:
					return CreatePistol(weaponTypeId, level, parent, at);
				case WeaponTypeId.Machinegun:
					return CreateMachinegun(weaponTypeId, level, parent, at);
				case WeaponTypeId.Sniper:
					return CreateSniper(weaponTypeId, level, parent, at);
				case WeaponTypeId.Shotgun:
					return CreateShotgun(weaponTypeId, level, parent, at);
			}

			throw new Exception($"Weapon for {weaponTypeId} type was not found");
		}

		private GameEntity CreatePistol(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isPistol = true)
			;

		private GameEntity CreateRevolver(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isRevolver = true)
		;

		private GameEntity CreateShotgun(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isShotgun = true)
		;

		private GameEntity CreateAutomaticPistol(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isAutomaticPistol = true)
		;
		private GameEntity CreateMachinegun(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isMachinegun = true)
		;

		private GameEntity CreateSniper(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isSniper = true)
		;

		private GameEntity CreatePlasmaGun(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isPlasmaGun = true)
		;

		private GameEntity CreateLaserBlaster(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isLaserBlaster = true)
		;

		private GameEntity CreateRocketLauncher(WeaponTypeId weaponTypeId, int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(weaponTypeId, level, parent, at)
				.With(x => x.isRocketLauncher = true)
		;

		private GameEntity CreateWeaponEntity(WeaponTypeId weaponTypeId, int weaponLevel, Transform parent, Vector2 at)
		{
			WeaponConfig config = _staticDataService.GetWeaponConfig(weaponTypeId);
			WeaponLevel level = _staticDataService.GetWeaponLevel(weaponTypeId, weaponLevel);

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWeaponTypeId(weaponTypeId)
					.AddViewPrefab(config.PrefabView)
					.AddViewParent(parent)
					.AddWorldPosition(at)
					.AddRadius(level.FireRange)
					.AddReloadTime(level.ReloadTime)
					.AddReloadTimeLeft(level.ReloadTime)
					.AddMagazineSize(level.MagazineSize)
					.AddCurrentAmmoAmount(level.MagazineSize)
					.AddMinPelletsSpreadAngle(level.MinSpreadAngle)
					.AddMaxPelletsSpreadAngle(level.MaxSpreadAngle)
					.AddCooldown(level.Cooldown)
					.With(x => x.isWeapon = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isMagazineNotEmpty = true)
					.With(x => x.AddMultiPellet(level.PelletCount), when: level.PelletCount > 1)
					.PutOnCooldown()
				;
		}
	}
}