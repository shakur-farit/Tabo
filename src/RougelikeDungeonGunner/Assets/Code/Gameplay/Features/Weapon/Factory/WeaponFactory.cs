using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Collection;
using Code.Gameplay.Features.Cooldowns;
using Code.Gameplay.Features.SpecialEffect;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.Features.Weapon.Services;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using Code.Meta.Features.Shop.WeaponUpgrade.Services;
using System;
using System.Linq;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Factory
{
	public class WeaponFactory : IWeaponFactory
	{
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;
		private readonly IWeaponStatsProvider _statsProvider;
		private readonly IWeaponEffectsProvider _effectsProvider;
    private readonly IWeaponStatusSetupProvider _setupProvider;

    public WeaponFactory(
			IIdentifierService identifier,
			IStaticDataService staticDataService,
			IWeaponStatsProvider statsProvider,
			IWeaponEffectsProvider effectsProvider,
      IWeaponStatusSetupProvider setupProvider)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
			_statsProvider = statsProvider;
			_effectsProvider = effectsProvider;
      _setupProvider = setupProvider;
    }

		public GameEntity CreateWeapon(WeaponTypeId weaponTypeId, Transform parent,
			Vector2 at, int ownerId, WeaponOwnerTypeId ownerTypeId)
		{
      WeaponConfig config = _staticDataService.GetWeaponConfig(weaponTypeId);
      CollisionCastSetup castSetup = config.CastSetup;

      switch (ownerTypeId)
			{
				case WeaponOwnerTypeId.Hero:
					return CreateHeroWeapon(config, parent, at, ownerId)
						.AddWeaponOwnerTypeId(WeaponOwnerTypeId.Hero)
            .AddForwardCastDistance(castSetup.ForwardCastDistance)
            .With(x => x.isHeroWeapon = true)
						;
				case WeaponOwnerTypeId.Enemy:
					return CreateEnemyWeapon(config, parent, at, ownerId)
						.AddWeaponOwnerTypeId(WeaponOwnerTypeId.Enemy)
						.With(x => x.isEnemyWeapon= true)
						.With(x => x.isShooting= true)
						;
				default:
					return null;
			}
		}

		private GameEntity CreateHeroWeapon(WeaponConfig config, Transform parent, Vector2 at, int ownerId)
		{
      switch (config.TypeId)
			{
				case WeaponTypeId.HeroPistol:
					return CreateHeroPistol(config, parent, at, ownerId);
				case WeaponTypeId.HeroRevolver:
					return CreateHeroRevolver(config, parent, at, ownerId);
				case WeaponTypeId.HeroMachinegun:
					return CreateHeroMachinegun(config, parent, at, ownerId);
				case WeaponTypeId.HeroSniper:
					return CreateHeroSniper(config, parent, at, ownerId);
				case WeaponTypeId.HeroShotgun:
					return CreateHeroShotgun(config, parent, at, ownerId);
				case WeaponTypeId.HeroLaserBlaster:
					return CreateHeroLaserBlaster(config, parent, at, ownerId);
				case WeaponTypeId.HeroAutoPistol:
					return CreateHeroAutomaticPistol(config, parent, at, ownerId);
				case WeaponTypeId.HeroPlasmaGun:
					return CreateHeroPlasmaGun(config, parent, at, ownerId);
				case WeaponTypeId.HeroBazuka:
					return CreateHeroRocketLauncher(config, parent, at, ownerId);
			}

			throw new Exception($"Weapon for {config.TypeId} type was not found");
		}

		private GameEntity CreateEnemyWeapon(WeaponConfig config, Transform parent, Vector2 at, int ownerId)
		{
			switch (config.TypeId)
			{
				case WeaponTypeId.EnemyPistol:
					return CreateEnemyPistol(config, parent, at, ownerId);
        case WeaponTypeId.EnemyMachinegun:
          return CreateEnemyMachinegun(config, parent, at, ownerId);
        case WeaponTypeId.EnemyCircleSigil:
					return EnemyCircleSigil(config, parent, at, ownerId);
				case WeaponTypeId.EnemyTriangleSigil:
					return EnemyTriangleSigil(config, parent, at, ownerId);
				case WeaponTypeId.EnemyStarSigil:
					return EnemyStarSigil(config, parent, at, ownerId);
        case WeaponTypeId.BossPistol:
          return CreateBossPistol(config, parent, at, ownerId);
				case WeaponTypeId.BossMachinegun:
					return CreateBossMachinegun(config, parent, at, ownerId);
			}

			throw new Exception($"Weapon for {config.TypeId} type was not found");
		}

		private GameEntity CreateHeroPistol(WeaponConfig config, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroPistol = true);

		private GameEntity CreateHeroRevolver(WeaponConfig config, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroRevolver = true);

		private GameEntity CreateHeroShotgun(WeaponConfig config, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroShotgun = true);

		private GameEntity CreateHeroAutomaticPistol(WeaponConfig config, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroAutomaticPistol = true);

		private GameEntity CreateHeroMachinegun(WeaponConfig config, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroMachinegun = true);

		private GameEntity CreateHeroSniper(WeaponConfig config, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroSniper = true);

		private GameEntity CreateHeroPlasmaGun(WeaponConfig config, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroPlasmaGun = true);

		private GameEntity CreateHeroLaserBlaster(WeaponConfig config, Transform parent, Vector2 at,
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroLaserBlaster = true);

		private GameEntity CreateHeroRocketLauncher(WeaponConfig config, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isHeroRocketLauncher = true);

		private GameEntity CreateEnemyPistol(WeaponConfig config, Transform parent, Vector2 at, 
			int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isEnemyPistol = true);

    private GameEntity CreateEnemyMachinegun(WeaponConfig config, Transform parent, Vector2 at,
      int ownerId) =>
      CreateWeaponEntity(config, parent, at, ownerId)
        .With(x => x.isEnemyMachinegun = true);

    private GameEntity EnemyCircleSigil(WeaponConfig config, Transform parent, Vector2 at, int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isEnemyCircleSigil = true);

		private GameEntity EnemyTriangleSigil(WeaponConfig config, Transform parent, Vector2 at, int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isEnemyTriangleSigil = true);

		private GameEntity EnemyStarSigil(WeaponConfig config, Transform parent, Vector2 at, int ownerId) =>
			CreateWeaponEntity(config, parent, at, ownerId)
				.With(x => x.isEnemyStarSigil = true);

    private GameEntity CreateBossPistol(WeaponConfig config, Transform parent, Vector2 at,
      int ownerId) =>
      CreateWeaponEntity(config, parent, at, ownerId)
        .With(x => x.isBossPistol = true);

    private GameEntity CreateBossMachinegun(WeaponConfig config, Transform parent, Vector2 at,
	    int ownerId) =>
	    CreateWeaponEntity(config, parent, at, ownerId)
		    .With(x => x.isBossMachinegun = true);

		private GameEntity CreateWeaponEntity(WeaponConfig config, Transform parent, Vector2 at, int ownerId)
		{

      return CreateGameEntity.Empty()
					.AddId(_identifier.Next())
					.AddWeaponTypeId(config.TypeId)
					.AddAmmoTypeId(config.AmmoTypeId)
					.AddAmmoPatternSetup(config.AmmoPatternSetup)
					.AddViewPrefab(config.ViewPrefab)
					.AddViewParent(parent)
					.AddWeaponOwnerId(ownerId)
					.AddWorldPosition(at)
					.AddDirection(default)
					.AddRadius(_statsProvider.GetFireRange(config))
					.AddMinPelletsDeviation(_statsProvider.GetMinDeviation(config))
					.AddMaxPelletsDeviation(_statsProvider.GetMaxDeviation(config))
					.AddCooldown(_statsProvider.GetCooldown(config))
					.AddShotSoundEffectTypeId(config.ShotSoundEffectTypeId)
					.AddReloadSoundEffectTypeId(config.ReloadSoundEffectTypeId)
					.With(x => x.isWeapon = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isMagazineNotEmpty = true)
					.With(x => x.isWeaponNotEmpty = true)
					.With(x => x.isReadyToShoot = true)
					.With(x => x.isReusable = true)
					.With(x => x.AddMultiPellet(config.Stats.PelletCount), when: config.Stats.PelletCount > 1)
					.With(x => x.AddPrechargeTime(_statsProvider.GetPrechargingTime(config)),
						when: _statsProvider.GetPrechargingTime(config) > 0)
					.With(x => x.AddPrechargeTimeLeft(_statsProvider.GetPrechargingTime(config)),
						when: _statsProvider.GetPrechargingTime(config) > 0)
					.With(x => x.AddMagazineSize(_statsProvider.GetMagazineSize(config)),
						when: config.Stats.isInfinityAmmo == false)
					.With(x => x.AddPierce(_statsProvider.GetPierce(config)),
						when: _statsProvider.GetPierce(config) > 0)
					.With(x => x.isInfinityAmmo = true, when: config.Stats.isInfinityAmmo)
					.With(x => x.AddCurrentAmmoCountInMagazine(_statsProvider.GetMagazineSize(config)),
						when: config.Stats.isInfinityAmmo == false)
					.With(x => x.AddMaxAmmoCount(_statsProvider.GetMaxAmmoCount(config)),
						when: config.Stats.isInfinityAmmo == false)
					.With(x => x.AddCurrentAmmoCount(_statsProvider.GetCurrentBulletsCount(config)),
						when: config.Stats.isInfinityAmmo == false && config.TypeId != WeaponTypeId.HeroBazuka)
          .With(x => x.AddCurrentAmmoCount(_statsProvider.GetCurrentMissilesCount(config)),
            when: config.Stats.isInfinityAmmo == false && config.TypeId == WeaponTypeId.HeroBazuka)
          .With(x => x.AddReloadTime(_statsProvider.GetReloadTime(config)),
						when: _statsProvider.GetReloadTime(config) > 0 && config.Stats.isInfinityAmmo == false)
					.With(x => x.AddReloadTimeLeft(_statsProvider.GetReloadTime(config)),
						when: _statsProvider.GetReloadTime(config) > 0 && config.Stats.isInfinityAmmo == false)
					.With(x => x.AddEffectSetups(_effectsProvider.GetEffects(config)),
						when: _effectsProvider.GetEffects(config).IsNullOrEmpty() == false)
					.With(x => x.AddMaxWeaponEnchantsCount(_statsProvider.GetEnchantSlots(config)),
						when: _statsProvider.GetEnchantSlots(config) > 0)
					.With(x => x.AddStatusSetups(_setupProvider.GetStatusSetups(config.TypeId).ToList()),
						when: _setupProvider.GetStatusSetups(config.TypeId).IsNullOrEmpty() == false)
					.With(x => x.AddSpecialEffectTypeId(config.SpecialEffectTypeId), 
						when: config.SpecialEffectTypeId != SpecialEffectTypeId.NoSpecialEffect)
					.PutOnCooldown()
				;
		}
	}
}