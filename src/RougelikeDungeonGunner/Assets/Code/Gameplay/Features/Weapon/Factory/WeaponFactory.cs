using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Meta.Features.Shop.Upgrade.Services;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public class WeaponFactory : IWeaponFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;
		private readonly IWeaponStatsProvider _statsProvider;
		private readonly IWeaponEffectsProvider _effectsProvider;

		public WeaponFactory(
			IIdentifierService identifier, 
			IStaticDataService staticDataService,
			IWeaponStatsProvider statsProvider,
			IWeaponEffectsProvider effectsProvider)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
			_statsProvider = statsProvider;
			_effectsProvider = effectsProvider;
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

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWeaponTypeId(weaponTypeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddViewParent(parent)
					.AddWeaponOwnerId(ownerId)
					.AddWorldPosition(at)
					.AddRadius(_statsProvider.GetFireRange(config))
					.AddMinPelletsDeviation(_statsProvider.GetMinDeviation(config))
					.AddMaxPelletsDeviation(_statsProvider.GetMaxDeviation(config))
					.AddCooldown(_statsProvider.GetCooldown(config))
					.AddMaxWeaponEnchantsCount(_statsProvider.GetEnchantSlots(config))
					.With(x => x.isWeapon = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isMagazineNotEmpty = true)
					.With(x => x.isReadyToShoot = true)
					.With(x => x.AddMultiPellet(config.Stats.PelletCount), when: config.Stats.PelletCount > 1)
					.With(x => x.AddPrechargeTime(_statsProvider.GetPrechargingTime(config)), 
						when: _statsProvider.GetPrechargingTime(config) > 0)
					.With(x => x.AddPrechargeTimeLeft(_statsProvider.GetPrechargingTime(config)), 
						when: _statsProvider.GetPrechargingTime(config) > 0)
					.With(x => x.AddMagazineSize(_statsProvider.GetMagazineSize(config)), 
						when: config.Stats.isInfinityAmmo == false)
					.With(x => x.isInfinityAmmo = true, when: config.Stats.isInfinityAmmo)
					.With(x => x.AddCurrentAmmoCount(_statsProvider.GetMagazineSize(config)), 
						when: config.Stats.isInfinityAmmo == false)
					.With(x => x.AddReloadTime(_statsProvider.GetReloadTime(config)), 
						when: _statsProvider.GetReloadTime(config) > 0 && config.Stats.isInfinityAmmo == false)
					.With(x => x.AddReloadTimeLeft(_statsProvider.GetReloadTime(config)), 
						when: _statsProvider.GetReloadTime(config) > 0 && config.Stats.isInfinityAmmo == false)
					.With(x => x.AddEffectSetups(_effectsProvider.GetEffects(config)), 
						when: _effectsProvider.GetEffects(config).IsNullOrEmpty() == false)
					.With(x => x.AddStatusSetups(config.StatusSetups), 
						when: config.StatusSetups.IsNullOrEmpty() == false)
					.PutOnCooldown()
				;
		}
	}
}