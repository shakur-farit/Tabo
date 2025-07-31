using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Meta.Features.Shop.Upgrade.Services;
using UnityEngine;
using Code.Gameplay.Features.TargetCollection;

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

		public GameEntity CreateWeapon(WeaponTypeId weaponTypeId, Transform parent,
			Vector2 at, int ownerId, WeaponOwnerTypeId ownerTypeId)
		{
			switch (ownerTypeId)
			{
				case WeaponOwnerTypeId.Hero:
					return CreateHeroWeapon(weaponTypeId, parent, at, ownerId)
						.AddWeaponOwnerTypeId(WeaponOwnerTypeId.Hero)
						.With(x => x.isHeroWeapon = true);
				case WeaponOwnerTypeId.Enemy:
					return CreateEnemyWeapon(weaponTypeId, parent, at, ownerId)
						.AddWeaponOwnerTypeId(WeaponOwnerTypeId.Enemy)
						.With(x => x.isEnemyWeapon= true);
				default:
					return null;
			}
		}

		private GameEntity CreateHeroWeapon(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId)
		{
			switch (weaponTypeId)
			{
				case WeaponTypeId.HeroPistol:
					return CreateHeroPistol(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.HeroRevolver:
					return CreateHeroRevolver(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.HeroMachinegun:
					return CreateHeroMachinegun(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.HeroSniper:
					return CreateHeroSniper(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.HeroShotgun:
					return CreateHeroShotgun(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.HeroLaserBlaster:
					return CreateHeroLaserBlaster(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.HeroAutoPistol:
					return CreateHeroAutomaticPistol(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.HeroPlasmaGun:
					return CreateHeroPlasmaGun(weaponTypeId, parent, at, ownerId);
				case WeaponTypeId.HeroRocketLauncher:
					return CreateHeroRocketLauncher(weaponTypeId, parent, at, ownerId);
			}

			throw new Exception($"Weapon for {weaponTypeId} type was not found");
		}

		private GameEntity CreateEnemyWeapon(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId)
		{
			switch (weaponTypeId)
			{
				case WeaponTypeId.EnemyPistol:
					return CreateEnemyPistol(weaponTypeId, parent, at, ownerId);
			}

			throw new Exception($"Weapon for {weaponTypeId} type was not found");
		}

		private GameEntity CreateHeroPistol(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroPistol = true);

		private GameEntity CreateHeroRevolver(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroRevolver = true);

		private GameEntity CreateHeroShotgun(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroShotgun = true);

		private GameEntity CreateHeroAutomaticPistol(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroAutomaticPistol = true);

		private GameEntity CreateHeroMachinegun(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroMachinegun = true);

		private GameEntity CreateHeroSniper(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroSniper = true);

		private GameEntity CreateHeroPlasmaGun(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroPlasmaGun = true);

		private GameEntity CreateHeroLaserBlaster(WeaponTypeId weaponTypeId, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroLaserBlaster = true);

		private GameEntity CreateHeroRocketLauncher(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isHeroRocketLauncher = true);

		private GameEntity CreateEnemyPistol(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(weaponTypeId, parent, at, ownerId)
				.With(x => x.isEnemyPistol = true);

		private GameEntity CreateWeaponEntity(WeaponTypeId weaponTypeId, Transform parent, Vector2 at, int ownerId)
		{
			WeaponConfig config = _staticDataService.GetWeaponConfig(weaponTypeId);
			CollisionCastSetup castSetup = config.CastSetup;


			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWeaponTypeId(weaponTypeId)
					.AddAmmoTypeId(config.AmmoTypeId)
					.AddViewPrefab(config.ViewPrefab)
					.AddViewParent(parent)
					.AddWeaponOwnerId(ownerId)
					.AddWorldPosition(at)
					.AddDirection(default)
					.AddRadius(_statsProvider.GetFireRange(config))
					.AddForwardCastDistance(castSetup.ForwardCastDistance)
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
					.With(x => x.AddPierce(_statsProvider.GetPierce(config)))
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