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
					return CreatePistol(level, parent, at);
				case WeaponTypeId.Machinegun:
					return CreateMachinegun(level, parent, at);
				case WeaponTypeId.Sniper:
					return CreateSniper(level, parent, at);
			}

			throw new Exception($"Weapon for {weaponTypeId} was not found");
		}

		private GameEntity CreatePistol(int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(WeaponTypeId.Pistol, level, parent, at)
				.With(x => x.isPistol = true)
			;

		private GameEntity CreateMachinegun(int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(WeaponTypeId.Machinegun, level, parent, at)
				.With(x => x.isPistol = true)
		;

		private GameEntity CreateSniper(int level, Transform parent, Vector2 at) =>
			CreateWeaponEntity(WeaponTypeId.Sniper, level, parent, at)
				.With(x => x.isPistol = true)
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
					.AddAmmoId(config.AmmoId)	
					.AddRadius(level.FireRange)
					.AddReloadTime(level.ReloadTime)
					.AddReloadTimeLeft(level.ReloadTime)
					.AddMagazineSize(level.MagazineSize)
					.AddCurrentAmmoAmount(level.MagazineSize)
					.AddCooldown(level.Cooldown)
					.With(x => x.isWeapon = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isMagazineNotEmpty = true)
					.PutOnCooldown()
				;
		}
	}
}